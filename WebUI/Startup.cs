using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebUI.App_Start.Startup))]
namespace WebUI.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
