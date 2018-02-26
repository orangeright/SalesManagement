using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesManagement.Startup))]
namespace SalesManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
