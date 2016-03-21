using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spofford.Web.Startup))]
namespace Spofford.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
