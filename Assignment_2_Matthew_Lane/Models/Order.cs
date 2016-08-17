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
        //[Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [RegularExpression(@"[A-Za-z][a-zA-Z]*", ErrorMessage = "First name not valid. ")]
        public virtual string FirstName { get; set; }
        //[Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [RegularExpression(@"[A-Za-z][a-zA-Z]*", ErrorMessage = "Last name not valid. ")]
        public virtual string LastName { get; set; }
       // [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address")]
        [RegularExpression(@"\d+[ ](?:[A-Za-z0-9.-]+[ ]?)+(?:Avenue|Lane|Road|Boulevard|Drive|Street|Ave|Dr|Rd|Blvd|Ln|St|st|rd|dr|ave|street|drive|boulevard|road|lane|avenue)\.?", ErrorMessage = "Address is not valid.")]
        public virtual string Address { get; set; }
       // [Required(ErrorMessage = "City is required")]
        [DisplayName("City")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "City is not valid.")]
        public virtual string City { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Province { get; set; }
       // [Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("Postal Code")]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]", ErrorMessage = "Postal code is not valid.")]
        public virtual string PostalCode { get; set; }
        [ScaffoldColumn(false)]
        public virtual string Country { get; set; }
       // [Required(ErrorMessage = "Phone number is required")]
        [DisplayName("Phone Number")]
        [RegularExpression(@"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$", ErrorMessage = "Phone number is not valid.")]
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