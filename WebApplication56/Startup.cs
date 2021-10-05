using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication56.Startup))]
namespace WebApplication56
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
