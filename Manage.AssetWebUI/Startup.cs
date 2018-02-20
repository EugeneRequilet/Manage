using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Manage.AssetWebUI.Startup))]
namespace Manage.AssetWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
