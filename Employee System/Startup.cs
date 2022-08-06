using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee_System.Startup))]
namespace Employee_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
