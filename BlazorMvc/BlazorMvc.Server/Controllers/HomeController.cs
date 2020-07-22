using Microsoft.AspNetCore.Mvc;

namespace BlazorMvc.Server.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
