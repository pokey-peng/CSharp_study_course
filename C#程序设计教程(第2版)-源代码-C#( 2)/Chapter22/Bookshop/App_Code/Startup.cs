using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookshop.Startup))]
namespace Bookshop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
