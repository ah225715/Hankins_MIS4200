using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hankins_MIS4200.Startup))]
namespace Hankins_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
