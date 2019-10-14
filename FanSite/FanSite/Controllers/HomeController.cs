using Microsoft.AspNetCore.Mvc;
using FanSite.Models;
using System.Linq;
using System;

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
            return View(FanSite.Models.Repository.Stories);
        }

        [HttpGet]
        public ViewResult StoryForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult StoryForm(Story story)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStory(story);
                return View("Stories");
            } else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult Sources()
        {
            return View();
        }
    }
}
