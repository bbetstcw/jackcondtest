using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jackcondtest.Startup))]
namespace jackcondtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
