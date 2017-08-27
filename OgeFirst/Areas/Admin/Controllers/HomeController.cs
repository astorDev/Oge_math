using OgeFirst.Domain.Services;
using OgeFirst.ViewModels.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgeFirst.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [AdminOnly]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel vm)
        {
            if (RegistrationService.IsAdmin(vm.ToDTO()))
            {
                var cookie = new HttpCookie("regcookies", "iamadminbitch");
                cookie.Expires = DateTime.Now.AddDays(2);
                HttpContext.Response.SetCookie(cookie);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
    }
}