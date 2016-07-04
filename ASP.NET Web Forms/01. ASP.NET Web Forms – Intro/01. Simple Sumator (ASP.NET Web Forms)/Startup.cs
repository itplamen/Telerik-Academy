using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.Simple_Sumator__ASP.NET_Web_Forms_.Startup))]
namespace _01.Simple_Sumator__ASP.NET_Web_Forms_
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
