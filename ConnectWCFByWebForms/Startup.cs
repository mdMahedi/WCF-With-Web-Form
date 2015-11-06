using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectWCFByWebForms.Startup))]
namespace ConnectWCFByWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
