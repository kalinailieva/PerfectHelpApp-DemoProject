using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PerfectHelp.Data.Constants;
using PerfectHelp.Data.Entity;

namespace PerfectHelp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = WebConstants.AdministratorRoleName)]
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            var news = new Newsletter();
         
         
            return View();
        }
    }
}
