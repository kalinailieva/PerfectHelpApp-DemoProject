using Microsoft.AspNetCore.Mvc;
using PerfectHelp.Data.Entity;

namespace PerfectHelp.Web.Controllers
{
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            var news = new Newsletter();


            return View();
        }
        public IActionResult GetSubscribed(string userId)
        {

            return Ok();
        }
    }
}
