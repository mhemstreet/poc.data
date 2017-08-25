using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(poc.web.Startup))]
namespace poc.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
