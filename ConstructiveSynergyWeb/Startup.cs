using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConstructiveSynergyWeb.Startup))]
namespace ConstructiveSynergyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
