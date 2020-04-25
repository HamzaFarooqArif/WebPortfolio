using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPortfolio.Startup))]
namespace WebPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
