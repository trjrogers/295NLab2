using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult History()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Stories()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Sources()
        {
            return View();
        }
    }
}
