using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterProject.Models;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {

        private WaterProjectContext context {get; set;}

        public HomeController(WaterProjectContext temp) => context = temp;
        public IActionResult Index()
        {
            var data = context.Projects.ToList();
            return View(data);
        }


    }
}
