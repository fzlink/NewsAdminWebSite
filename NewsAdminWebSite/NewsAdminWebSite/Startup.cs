using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsAdminWebSite.Startup))]
namespace NewsAdminWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
