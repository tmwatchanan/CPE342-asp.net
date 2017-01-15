using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OracleCon.Startup))]
namespace OracleCon
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
