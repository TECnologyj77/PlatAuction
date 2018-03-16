using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PlatAuction.Backend.Startup))]

namespace PlatAuction.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}