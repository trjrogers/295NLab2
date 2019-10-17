using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanSite.Models;

namespace FanSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        public ViewResult Stories()
        {
            return View(Repository.Stories);
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

        public ViewResult Sources()
        {
            return View();
        }
    }
}
