using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Controllers
{
    public class Donation : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Donation());
        }
    }
}
