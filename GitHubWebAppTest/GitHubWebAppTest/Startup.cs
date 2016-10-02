using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubWebAppTest.Startup))]
namespace GitHubWebAppTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
