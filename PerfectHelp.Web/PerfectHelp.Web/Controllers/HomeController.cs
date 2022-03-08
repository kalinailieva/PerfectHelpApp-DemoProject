using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PerfectHelp.Data.Entity;
using PerfectHelp.Web.Models;
using System.Diagnostics;

namespace PerfectHelp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
       


        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var user = User.Identity.Name;
            if (user != null)
            {
                var userIdentity = userManager.FindByNameAsync(user).Result;
                var role = userManager.IsInRoleAsync(userIdentity, "Admin").Result;
            }
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}