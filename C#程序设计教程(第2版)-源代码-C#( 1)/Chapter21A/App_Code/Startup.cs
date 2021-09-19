using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chapter21A.Startup))]
namespace Chapter21A
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
