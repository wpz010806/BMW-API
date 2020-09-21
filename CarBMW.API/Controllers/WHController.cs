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

        [HttpGet]
        [Route("api/GetWD")]
        public async Task<ActionResult<IEnumerable<WDandWTView>>> GetWD()
        {
            var Linq = from wd in db.WarehouesDetailInfo
                       join wt in db.WarehouesTypeInfo
                       on wd.WTId equals wt.WTId
                       select new WDandWTView()
                       {
                           WDId = wd.WDId,
                           WDName=wd.WDName,
                           WDCount=wd.WDCount,
                           WDState=wd.WDState,
                           CarMessageId=wd.CarMessageId,
                           WTId=wt.WTId,
                           WTName=wt.WTName,
                           WTCup=wt.WTCup,
                           WTState=wt.WTState
                       };
            return await Linq.ToListAsync();
        }

        public async Task<ActionResult<IEnumerable<>>>
    }
}
