using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imaw.Startup))]
namespace imaw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
