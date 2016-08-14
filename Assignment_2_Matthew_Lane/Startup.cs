/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : AccountController.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is Startup.cs file, used to provide configuations duing the start up process
  
------------------------------------------------------------------------------*/

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_2_Matthew_Lane.Startup))]
namespace Assignment_2_Matthew_Lane
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        } 
    }
}
