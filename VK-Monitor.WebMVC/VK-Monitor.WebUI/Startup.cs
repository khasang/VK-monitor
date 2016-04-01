using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VK_Monitor.WebUI.Startup))]
namespace VK_Monitor.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
