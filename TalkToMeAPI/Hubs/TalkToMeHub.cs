using Microsoft.AspNet.SignalR;

namespace TalkToMeAPI.Hubs
{
    /// <summary>
    /// A SignalR hub that will invoke all connected clients
    /// </summary>
    public class TalkToMeHub : Hub
    {
        public void Speak(string textToSay)
        {
            //Invoke method on all connected clients 
            Clients.All.speak(textToSay);
        }
    }
}