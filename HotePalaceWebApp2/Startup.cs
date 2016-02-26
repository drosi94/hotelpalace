using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotePalaceWebApp2.Startup))]
namespace HotePalaceWebApp2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
