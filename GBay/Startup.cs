using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GBay.Startup))]
namespace GBay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
