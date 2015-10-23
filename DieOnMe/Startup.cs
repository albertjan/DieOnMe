[assembly: Microsoft.Owin.OwinStartup(typeof(DieOnMe.Startup))]
namespace DieOnMe
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseNancy();
        }
    }
}