using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductOrder.Models;
using ProductOrder.Models.DTO;
namespace ProductOrder.Controllers
{
    public class OrderController : Controller
    {
        OrderProductsEntities db = new OrderProductsEntities();
        // GET: Order
        public ActionResult Index()
        {
            List<Order> orders = new List<Order>();
            orders = db.Orders.ToList<Order>();

            return View(orders);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            
            return View();
        }
        
        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order orders)
        {
            try
            {
                // TODO: Add insert logic here
                orders.created_date = DateTime.Now;
                orders.updated_date = DateTime.Now;
                db.Orders.Add(orders);
                if(db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }
       
        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            Order orders = new Order();
            orders = db.Orders.Where(x=> x.id==id).FirstOrDefault<Order>();
            ViewData["customer_id"] = orders.customer_id;
            ViewData["product_id"] = orders.product_id;
            return View(orders);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Order orders)
        {
            try
            {
                Order order = new Order();
                order = db.Orders.Where(x => x.id == id).FirstOrDefault<Order>();
                order.qty = orders.qty;
                order.total_price = orders.total_price;
                order.updated_date = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = new Order();
            order = db.Orders.Where(x => x.id == id).FirstOrDefault<Order>();
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
