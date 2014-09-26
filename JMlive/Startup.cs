using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JMlive.Startup))]
namespace JMlive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
