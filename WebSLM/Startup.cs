using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSLM.Startup))]
namespace WebSLM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
