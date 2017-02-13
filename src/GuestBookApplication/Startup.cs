using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GuestBookApplication.Startup))]
namespace GuestBookApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
