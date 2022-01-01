using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductOrder.Models;
namespace ProductOrder.Controllers.API
{
    
    public class GetDataController : ApiController
    {
        private OrderProductsEntities db = null;
        public GetDataController()
        {
            db = new OrderProductsEntities();
        }
        [Route("api/Masters/GetCustomer")]
        public IHttpActionResult getCustomer()
        {
            
                var customerData = (from customers in db.Customers
                                    where customers.IsActive == true
                                    select new { id = customers.id, Name = customers.first_name + " " + customers.last_name }
                ).ToList().Select(x => new Customer() { id = x.id, first_name = x.Name });
                 
            
            return Ok(customerData);
        }
        [Route("api/Masters/GetProducts")]
        public IHttpActionResult getProducts()
        {
            var productData = (from products in db.Products
                                where products.IsActive == true
                                select new { id = products.id, Name = products.name}
                ).ToList().Select(x => new Product() { id = x.id, name = x.Name });
            return Ok(productData);
        }
        [Route("api/Products/GetPrice/{product_id}")]
        public IHttpActionResult getProductChange(int product_id)
        {
            
           var unit_Price = (from products in db.Products
                             where products.id == product_id
                             select new { price = products.unit_price }
                ).ToList().Select(x => new Product() { unit_price = x.price});
            return Ok(unit_Price);
        }
    }
}
