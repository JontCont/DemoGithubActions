using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_CI_Demo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CI_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string json = JsonConvert.SerializeObject(new { Success = false }, Formatting.None);
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


        public string Get_DataTableAt()
        {
            return JsonConvert.SerializeObject(new { Success = true, Message = "" }, Formatting.None);
        }
    }
}
