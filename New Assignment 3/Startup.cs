using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_Assignment_3.Startup))]
namespace New_Assignment_3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
