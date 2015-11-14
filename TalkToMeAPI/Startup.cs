using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TalkToMeAPI.Startup))]
namespace TalkToMeAPI
{
    /// <summary>
    /// Startup class for the Owin pipeline where SignalR will be enabled.
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
