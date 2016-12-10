using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BurgasTeamBlog.Startup))]
namespace BurgasTeamBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //comentar
            //comentarnewmariela
            //commet Valeri
            //treticomentarmariela
        }
    }
}
