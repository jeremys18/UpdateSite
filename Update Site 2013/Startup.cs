using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Update_Site_2013.Startup))]
namespace Update_Site_2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
