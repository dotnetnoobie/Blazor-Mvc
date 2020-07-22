using Microsoft.AspNetCore.Mvc;

namespace BlazorMvc.Server.Controllers
{
    [Route("[controller]")]
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}