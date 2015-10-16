using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroToASP.NETMVC.Startup))]
namespace IntroToASP.NETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
