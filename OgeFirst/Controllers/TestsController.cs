using OgeFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgeFirst.Controllers
{
    public class TestsController : Controller
    {
        TestViewModel sbm = new TestViewModel();
        
        // GET: Tests
        public ActionResult Index(int id, TestType type)
        {
            return View(new TestViewModel(id, type));
        }

        [HttpPost]
        public ActionResult Index(TestViewModel submission)
        {
            if (!ModelState.IsValid)
            {
                var vm = new TestViewModel(submission);
                return View("Index", vm);
            }

            TempData["sbm"] = submission;
            return RedirectToAction("Results");
        }

        public ActionResult Results()
        {
            return View(new ResultsViewModel((TestViewModel)TempData["sbm"]));
        }
    }
}