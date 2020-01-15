using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleFW.Retail.Web.Startup))]
namespace SampleFW.Retail.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
