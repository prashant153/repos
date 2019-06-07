using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeToFoodMvc4.Startup))]
namespace OdeToFoodMvc4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
