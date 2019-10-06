using Microsoft.AspNetCore.Mvc;

namespace FanSite.Controllers
{
    public class SourcesController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult PhysicalMedia()
        {
            return View();
        }

        [HttpGet]
        public ViewResult OnlineMedia()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Home()
        {
            return View();
        }
    }
}