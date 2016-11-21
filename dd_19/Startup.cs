using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dd_19.Startup))]
namespace dd_19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
