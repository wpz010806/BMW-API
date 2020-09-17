using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CarBMW.API.Controllers
{
    [EnableCors("cors")]
    [ApiController]
    public class WHController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
