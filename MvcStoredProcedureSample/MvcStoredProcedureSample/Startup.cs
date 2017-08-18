using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcStoredProcedureSample.Startup))]
namespace MvcStoredProcedureSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
