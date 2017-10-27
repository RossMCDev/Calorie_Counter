using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WalkOffCalories.Models;


namespace WalkOffCalories.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Calculate()
        {
            //Walk walk = new Walk();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate([Bind(Include = "PersonHeaviness,PersonFeet,PersonInches,PersonAge,PersonGender,Distance,WalkHours,WalkMinutes,WalkSeconds")]Walk walk)
        {
            double meterstraveled = walk.Distance * 1609.34;
            double kiloweight = walk.PersonHeaviness * 0.453592;
            double meterheight = (walk.PersonFeet * 0.3048) + (walk.PersonInches * 0.0254);
            double timetaken = walk.WalkSeconds + ((walk.WalkMinutes+ (walk.WalkHours*60))*60);
            double speed = meterstraveled/timetaken;
            walk.CalorieCount = Math.Round(((0.035 * kiloweight) + ((speed * speed) / meterheight) * (0.029) * (kiloweight)) * (timetaken / 60));
            if (double.IsNaN(walk.CalorieCount)) walk.CalorieCount = 0;
            return View(walk);
        }
    }
}