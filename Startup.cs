using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSP_test.Startup))]
namespace MSP_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
