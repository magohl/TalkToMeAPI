using System.Web.Mvc;

namespace TalkToMeAPI.Controllers
{
    /// <summary>
    /// This MVC controller handles the UI part that will
    /// be started in one (or more) browser instances.
    /// This could instead be a static HTML page without MVC
    /// but lets prepare for some more functionality later on.
    /// </summary>
    public class LoudspeakerController : Controller
    {
        public ActionResult Index()
        {
            //Nothing special here now.
            return View();
        }
    }
}