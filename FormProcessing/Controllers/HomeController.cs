using FormProcessing.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormProcessing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormProcess formProcess)
        {
            FormProcess formProcessResult = new FormProcess();
            formProcessResult.Result = formProcess.Months.AddDays(formProcess.Days).ToString("dd/MM/yyyy");
            return View(formProcessResult);
        }
    }
}
