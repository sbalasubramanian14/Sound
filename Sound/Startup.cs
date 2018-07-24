using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sound.Startup))]
namespace Sound
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
