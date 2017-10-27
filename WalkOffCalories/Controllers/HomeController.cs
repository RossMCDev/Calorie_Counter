using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WalkOffCalories.Models;
using System.Net;
using System.Web.Mvc.Ajax;

namespace WalkOffCalories.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("Calculate", "Calculator");
        }
    }
}