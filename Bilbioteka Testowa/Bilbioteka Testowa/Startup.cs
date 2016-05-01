using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bilbioteka_Testowa.Startup))]
namespace Bilbioteka_Testowa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
