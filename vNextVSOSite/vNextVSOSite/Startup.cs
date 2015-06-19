using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vNextVSOSite.Startup))]
namespace vNextVSOSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
