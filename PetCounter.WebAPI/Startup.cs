using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetCounter.WebAPI.Startup))]
namespace PetCounter.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
