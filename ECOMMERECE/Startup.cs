using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECOMMERECE.Startup))]
namespace ECOMMERECE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
