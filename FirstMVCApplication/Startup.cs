using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KavyaStockTrading.Startup))]
namespace KavyaStockTrading
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
