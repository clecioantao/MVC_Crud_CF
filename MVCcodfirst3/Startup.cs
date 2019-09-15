using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCcodfirst3.Startup))]
namespace MVCcodfirst3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
