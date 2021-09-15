using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CJ7844___PRG522_SA.Startup))]
namespace CJ7844___PRG522_SA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
