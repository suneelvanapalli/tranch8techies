using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigiCartClient.Startup))]
namespace DigiCartClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
