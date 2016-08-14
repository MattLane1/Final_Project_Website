/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : OrderDetail.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is OrderDetail page, which is the model for the information about the order the user is placing
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.Models
{
    /*Provide information about the order to the user*/
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