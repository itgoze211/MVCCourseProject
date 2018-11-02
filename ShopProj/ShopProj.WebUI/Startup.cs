using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopProj.WebUI.Startup))]
namespace ShopProj.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
