using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Assignment_2_Matthew_Lane.Models
{
    public class Order
    {
        [ScaffoldColumn(false)]
        public virtual int OrderId { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Username { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Province { get; set; }
        public virtual string PostalCode { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Email { get; set; }
        [ScaffoldColumn(false)]
        public virtual decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public virtual System.DateTime OrderDate { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}