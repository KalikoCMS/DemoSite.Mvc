using DemoSite;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace DemoSite {
    using Owin;

    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}