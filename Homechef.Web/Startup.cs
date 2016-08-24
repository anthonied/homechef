using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homechef.Web.Startup))]
namespace Homechef.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
