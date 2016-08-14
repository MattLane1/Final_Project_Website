/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : ShoppingCartViewModel.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is ShoppingCartView model used to allow a user to view the contense of their cart
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_2_Matthew_Lane.Models;

namespace Assignment_2_Matthew_Lane.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}