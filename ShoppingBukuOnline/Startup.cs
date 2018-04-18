using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingBukuOnline.Startup))]
namespace ShoppingBukuOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
