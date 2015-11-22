using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using TalkToMeAPI.Hubs;
using TalkToMeAPI.Models;

namespace TalkToMeAPI.Controllers
{
    /// <summary>
    /// This API controller exposed as an API API will invoke the SignalR Hub
    /// thus invoking the text-to-speach client side javascript in the connected
    /// browser.
    /// TO TEST TEST DIRECTLY MAKE A REQUEST LIKE THIS
    /// Method: HTTP POST
    /// URL: http://{your-apiapp-url}/api/TalkToMe
    /// Content-Type : application/json
    /// Body: { "TextToRead" : "Nice weather today" }
    /// </summary>
    public class TalkToMeController : ApiController
    {
        public async Task<IHttpActionResult> Speak([FromBody]Speach speach)
        {
            //Connect the the SignalR hub
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<TalkToMeHub>();
            //Invoke the method on the hub.
            await context.Clients.All.Speak(speach.TextToRead);
            //Return HTTP statuscode 202/Accepted.
            return StatusCode(HttpStatusCode.Accepted);
        }

    }
}
