using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplikacija7.Startup))]
namespace Aplikacija7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
