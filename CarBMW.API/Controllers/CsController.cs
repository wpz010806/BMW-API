using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBMW.API.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//测试控制器
namespace CarBMW.API.Controllers
{
    //测试
    [Route("api/[controller]")]
    [ApiController]
    public class CsController : ControllerBase
    {
        //依赖注入
        public Dbcontext db;

        public CsController(Dbcontext db) { this.db = db; }

    }
}
