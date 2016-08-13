using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int FoodID { get; set; }
        public virtual Food food { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}