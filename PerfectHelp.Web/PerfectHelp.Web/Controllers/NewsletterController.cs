using Microsoft.AspNetCore.Mvc;
using PerfectData.Services.Interfaces;
using PerfectHelp.Data.Entity;

namespace PerfectHelp.Web.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly INewsletterService newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            this.newsletterService = newsletterService;
        }
        public IActionResult Index()
        {
            var news = new Newsletter();


            return View();
        }
        public IActionResult GetSubscribed(string name, string email)
        {
            newsletterService.GetSubscribed(name, email);  
           
            return Ok(email);
        }
    }
}
