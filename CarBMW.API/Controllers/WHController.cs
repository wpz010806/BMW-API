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

        /// <summary>
        /// 仓库类型显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetWT")]
        public async Task<ActionResult<IEnumerable<WarehouesTypeInfo>>> GetWT()
        {
            return await db.WarehouesTypeInfo.ToArrayAsync();
        }

        /// <summary>
        /// 仓库具体信息显示
        /// </summary>
        /// <returns></returns>
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
                           WDName = wd.WDName,
                           WDCount = wd.WDCount,
                           WDState = wd.WDState,
                           WTId = wt.WTId,
                           WTName = wt.WTName,
                           WTCup = wt.WTCup,
                           WTState = wt.WTState
                       };
            return await Linq.ToListAsync();
        }

        /// <summary>
        /// 入库记录显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetInw")]
        public async Task<ActionResult<IEnumerable<InWarehouesInfo>>> GetInW()
        {
            return await db.InWarehouesInfo.ToArrayAsync();
        }

        /// <summary>
        /// 出库记录显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetOutW")]
        public async Task<ActionResult<IEnumerable<OutWarehouesInfo>>> GetOutW()
        {
            return await db.OutWarehouesInfo.ToArrayAsync();
        }

        /// <summary>
        /// 调拨记录显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetAllotW")]
        public async Task<ActionResult<IEnumerable<AllotWarehouesInfo>>> GetAllotW()
        {
            return await db.AllotWarehouesInfo.ToArrayAsync();
        }
    }
}
