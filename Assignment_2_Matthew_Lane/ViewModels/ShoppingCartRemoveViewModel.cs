/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : AccountController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is ShoppingCartRemoveViewModel, used to remove items from the cart
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_Matthew_Lane.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteId { get; set; }
    }
}