using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MockAssessment5.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(int num1, int num2, string operation)
        {
            if(operation == "Plus")
            {
                ViewBag.Result = num1 + num2;
                ViewBag.Operation = "+";
            }
            else if (operation == "Minus")
            {
                ViewBag.Result = num1 - num2;
                ViewBag.Operation = "-";
            }
            else if (operation == "Multiply")
            {
                ViewBag.Result = num1 * num2;
                ViewBag.Operation = "*";
            }
            else if (operation == "Divide")
            {
                ViewBag.Result = num1 / num2;
                ViewBag.Operation = "/";
            }
            else //how did you get here hackerman?
            {
                ViewBag.Result = 0;
            }

            return View();
        }
    }
}