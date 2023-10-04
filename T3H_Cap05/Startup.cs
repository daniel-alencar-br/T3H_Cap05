using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T3H_Cap05.Startup))]
namespace T3H_Cap05
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
