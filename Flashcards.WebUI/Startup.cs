using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flashcards.WebUI.Startup))]
namespace Flashcards.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
