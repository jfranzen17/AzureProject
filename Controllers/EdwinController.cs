using AzureProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AzureProject.Controllers
{
    public class EdwinController : Controller
    {
        private readonly ILogger<EdwinController> _logger;

        public EdwinController(ILogger<EdwinController> logger)
        {
            _logger = logger;
        }

        public IActionResult Edwin()
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
