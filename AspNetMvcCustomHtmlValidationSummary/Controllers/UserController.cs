using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcCustomHtmlValidationSummary.ViewModels;

namespace AspNetMvcCustomHtmlValidationSummary.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            var userViewModel = new UserViewModel();

            return View(userViewModel);
        }

        [HttpPost]
        public ActionResult Save(UserViewModel userViewModel)
        {
            // TODO: do something here with postback values... :)

            return RedirectToAction("Index");
        }

    }
}
