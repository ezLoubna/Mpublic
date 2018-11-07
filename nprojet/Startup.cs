using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nprojet.Startup))]
namespace nprojet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
