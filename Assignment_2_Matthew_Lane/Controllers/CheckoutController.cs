/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : CheckoutController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is controller for the checkout functions
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2_Matthew_Lane.Models;

namespace Assignment_2_Matthew_Lane.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        FoodStoreContext storeDB = new FoodStoreContext();

        const string PromoCode = "FREE";
        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            bool badInput = false;
            var order = new Order();
            TryUpdateModel(order);

            if(order.City == null)
            {
                badInput = true;
            }

            if (order.FirstName == null)
            {
                badInput = true;
            }

            if (order.LastName == null)
            {
                badInput = true;
            }

            if (order.Phone == null)
            {
                badInput = true;
            }

            if (order.PostalCode == null)
            {
                badInput = true;
            }

            if (order.Address == null)
            {
                badInput = true;
            }

            if (badInput == false)
            {
                try
                {
                    if (string.Equals(values["PromoCode"], PromoCode,
                        StringComparison.OrdinalIgnoreCase) == false)
                    {
                        return View(order);
                    }
                    else
                    {
                        order.Username = User.Identity.Name;
                        order.OrderDate = DateTime.Now;

                        //Save Order
                        storeDB.Orders.Add(order);
                        storeDB.SaveChanges();
                        //Process the order
                        var cart = ShoppingCart.GetCart(this.HttpContext);
                        cart.CreateOrder(order);

                        return RedirectToAction("Complete",
                            new { id = order.OrderId });
                    }
                }
                catch
                {
                    //Invalid - redisplay with errors
                    return View(order);
                }
            }

            else
                //Invalid - redisplay with errors
                return View(order);

        }
        //
        // GET: /Checkout/Complete
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = storeDB.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}