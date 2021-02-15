using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter(DistanceConverter converter)
        {
            if (converter.FromDistance > 0)
            {
                converter.CalculateDistance();
            }

            return View(converter);
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMICalculator bmi)
        {
            if (bmi.Centimetres > 140)
            {
                bmi.CalculateMetric();
            }
            else if ((bmi.Feet > 4) && (bmi.Stones > 6))
            {
                bmi.CalculateImperial();
            }
            else
            {
                ViewBag.Error = "You have inputted values too small for any adult. " +
                    "Please try again.";
                return View();
            }

            double bmiIndex = bmi.User_BMI;

            // TODO: Ask Derek in the next session to look at this
            // (not redirecting after clicking Calculate button
            return RedirectToAction("DisplayWeightStatus", new { bmiIndex });
        }

        public IActionResult DisplayWeightStatus(double bmiIndex)
        {
            return View(bmiIndex);
        }

        public IActionResult StudentMarks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
