using OgeFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgeFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View(new SubtopicsListViewModel());
        }

        public ActionResult Hidden()
        {
            return View();
        }
    }
}