using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNetNewsApp.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("admin")]
        [Route("login")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
