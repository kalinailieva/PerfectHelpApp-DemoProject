using Microsoft.AspNetCore.Mvc;

namespace PerfectHelp.Web.Areas.Admin.Controllers
{
    public class AdminNewsletterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
