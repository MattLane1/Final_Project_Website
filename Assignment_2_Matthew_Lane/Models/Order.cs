/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : Order.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is the orders page. When a user wants to place an order, this requests their information. 
  
------------------------------------------------------------------------------*/

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Assignment_2_Matthew_Lane.Models
{
    /*Request the users information, there where there is no ScaffoldColumn(false) line above it. These lines are automatically generated*/
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