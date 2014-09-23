using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsShop.Startup))]
namespace CarsShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
