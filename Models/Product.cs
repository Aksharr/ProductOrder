//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
