using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vindy.Startup))]
namespace Vindy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
