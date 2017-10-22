using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Miles.People.MobileAppService.Startup))]

namespace Miles.People.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}