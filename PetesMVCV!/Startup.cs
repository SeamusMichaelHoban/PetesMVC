using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetesMVCV_.Startup))]
namespace PetesMVCV_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
