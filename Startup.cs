using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobShop.Startup))]
namespace JobShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
