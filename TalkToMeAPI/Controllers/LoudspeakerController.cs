using System.Web.Mvc;

namespace TalkToMeAPI.Controllers
{
    /// <summary>
    /// This MVC controller handles the Loudspeaker UI that will
    /// need to be started in at least one browser
    /// </summary>
    public class LoudspeakerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}