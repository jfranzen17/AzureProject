using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektArbeteAzure.Controllers
{
    public class JohanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Enquiry()
        {
            string test = "halooooo";
            return View(test);
        }
    }
}
