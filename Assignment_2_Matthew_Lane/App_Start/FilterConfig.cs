/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : FilterConfig.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is FilterConfig file required by MVC
  
------------------------------------------------------------------------------*/

using System.Web;
using System.Web.Mvc;

namespace Assignment_2_Matthew_Lane
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
