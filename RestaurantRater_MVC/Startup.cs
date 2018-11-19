using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantRater_MVC.Startup))]
namespace RestaurantRater_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
