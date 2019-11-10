using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLevio.Startup))]
namespace WebLevio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
