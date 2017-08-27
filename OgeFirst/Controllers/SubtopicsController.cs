using OgeFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgeFirst.Controllers
{
    public class SubtopicsController : Controller
    {
        // GET: Subtopics
        public ActionResult Index(int id)
        {

            return View(new SubtopicViewModel(id));
        }
    }
}