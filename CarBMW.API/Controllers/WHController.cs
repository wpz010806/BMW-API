using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBMW.API.MODEL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;

namespace CarBMW.API.Controllers
{
    [EnableCors("cors")] //设置跨域处理的代理
    [ApiController]
    public class WHController : Controller
    {
        public Dbcontext db;

        public WHController(Dbcontext db) { this.db = db; }
        //日志使用
        //LogHelper log = new LogHelper();

        [HttpGet]
        [Route("api/GetWT")]
        public async Task<ActionResult<IEnumerable<WarehouesTypeInfo>>> GetWT()
        {
            return await db.WarehouesTypeInfo.ToArrayAsync();
        }
    }
}
