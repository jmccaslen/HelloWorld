using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crowe_HelloWorld.Startup))]
namespace Crowe_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
