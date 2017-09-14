using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fine_Arts.Startup))]
namespace Fine_Arts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
