using Microsoft.AspNetCore.Mvc;

namespace PerfectHelp.Web.Controllers
{
    public class MySpaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
