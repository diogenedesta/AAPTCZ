using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AAPTZACS.Startup))]
namespace AAPTZACS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
