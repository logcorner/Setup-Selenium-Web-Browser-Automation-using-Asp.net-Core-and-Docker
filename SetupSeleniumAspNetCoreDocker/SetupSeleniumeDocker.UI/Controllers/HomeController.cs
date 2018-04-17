using Microsoft.AspNetCore.Mvc;
using SetupSeleniumeDocker.UI.DataModel;
using SetupSeleniumeDocker.UI.Models;
using System.Diagnostics;
using System.Linq;

namespace SetupSeleniumeDocker.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly LogcornerBlogpostContext _dbContext;

        public HomeController(LogcornerBlogpostContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
           _dbContext.Blogs.Add(new Blogs
           {
               Owner = "4008d0cd-2547-450b-a2a2-20396a39f64d",
               Description = "descvvvvvvvvvvvvvvvvvvvvvv",
               Url = "http://yahoo.fr",
           });
            _dbContext.SaveChanges();

            return View(_dbContext.Blogs.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}