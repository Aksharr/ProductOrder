using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductOrder.Models.DTO
{
    public class OrderListDTO
    {
        public int id { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public Nullable<int> product_id { get; set; }
        [DisplayName("Unit Price")]
        public Nullable<decimal> unit_price { get; set; }
        [DisplayName("Quantity")]
        public Nullable<int> qty { get; set; }
        [DisplayName("Total Price")]
        public Nullable<decimal> total_price { get; set; }
        [DisplayName("Order Created")]
        public Nullable<System.DateTime> created_date { get; set; }
        [DisplayName("Order Updated")]
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}