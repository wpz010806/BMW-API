﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBMW.API.MODEL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;

namespace CarBMW.API.Controllers
{
    [EnableCors("cors")]
    [ApiController]
    public class WHController : Controller
    {
        public Dbcontext db;

        public WHController(Dbcontext db) { this.db = db; }
        //日志使用
        LogHelper log = new LogHelper();

        public IActionResult Index()
        {
            return View();
        }
    }
}
