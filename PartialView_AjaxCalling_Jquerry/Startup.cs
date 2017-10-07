using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialView_AjaxCalling_Jquerry.Startup))]
namespace PartialView_AjaxCalling_Jquerry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
