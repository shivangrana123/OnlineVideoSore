using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineVideoSore.Startup))]
namespace OnlineVideoSore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
