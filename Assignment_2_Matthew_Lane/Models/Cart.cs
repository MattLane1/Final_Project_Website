/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : Cart.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is Cart.cs page, it is the model for the cart, and specifies what the cart object will contain
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.Models
{
    /*This is the cart object. it contains information about what is in a users cart*/
    public class Cart
    {
        [Key]
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int Count { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual int FoodID { get; set; }
        public virtual Food Food { get; set; }
    }
}