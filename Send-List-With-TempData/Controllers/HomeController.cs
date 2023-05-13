using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Send_List_With_TempData.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Required reference
using Newtonsoft.Json;

namespace Send_List_With_TempData.Controllers
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
            //List for send with tempData
            var user = new List<User>()
            {
                new User(){Name = "Ali", Family = "Abbasi"},
                new User(){Name = "Mohammad", Family = "Abbasi"},
                new User(){Name = "Jhon", Family = "Abbasi"},
                new User(){Name = "Danny", Family = "Abbasi"},
                new User(){Name = "Mary", Family = "Abbasi"},
                new User(){Name = "Hossien", Family = "Abbasi"}
            };

            //TempData
            TempData["user"] = JsonConvert.SerializeObject(user);

            //Go to view to continue
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
