using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EdgeTechWebApp.Startup))]
namespace EdgeTechWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
