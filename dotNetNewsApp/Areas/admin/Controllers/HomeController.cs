using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNetNewsApp.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("admin")]
        [Route("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
