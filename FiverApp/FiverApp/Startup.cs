using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiverApp.Startup))]
namespace FiverApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
