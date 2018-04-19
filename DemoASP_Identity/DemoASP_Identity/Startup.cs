using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoASP_Identity.Startup))]
namespace DemoASP_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
