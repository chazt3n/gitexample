using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitExample.Startup))]
namespace GitExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
