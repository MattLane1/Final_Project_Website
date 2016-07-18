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
