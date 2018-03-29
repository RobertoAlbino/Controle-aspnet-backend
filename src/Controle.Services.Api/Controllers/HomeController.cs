using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Services.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("api")]
        public IActionResult Home()
        {
            return View();
        }
    }
}