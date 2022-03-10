using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAuthentication_9march_.Startup))]
namespace MVCAuthentication_9march_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
