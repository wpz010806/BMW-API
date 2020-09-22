using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CarBMW.API.MODEL;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
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

        /// <summary>
        /// 调用入库存储过程
        /// </summary>
        /// <param name="IWNum">入库单号</param>
        /// <param name="WDId">入库仓库ID</param>
        /// <param name="CMId">车辆信息ID</param>
        /// <param name="CSId">车辆类别ID</param>
        /// <param name="IWCount">入库数量</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Proc_InW")]
        public DataTable Proc_InW(string IWNum, int WDId, int CMId, int CSId, int IWCount)
        {
            SqlParameter[] parameter = {
                new SqlParameter("_IWNum",IWNum),
                new SqlParameter("_WDId",WDId),
                new SqlParameter("_CMId",CMId),
                new SqlParameter("_CSId",CSId),
                new SqlParameter("_IWCount",IWCount)
            };
            return DBhelper.DoProc("Proc_InW", parameter);
        }

        /// <summary>
        /// 调用出库存储过程
        /// </summary>
        /// <param name="OWNum">出库单号</param>
        /// <param name="WDId">出库仓库ID</param>
        /// <param name="CMId">车辆信息ID</param>
        /// <param name="CSId">车辆类别ID</param>
        /// <param name="OWCount">出库数量</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Proc_OutW")]
        public DataTable Proc_OutW(string OWNum, int WDId, int CMId, int CSId, int OWCount)
        {
            SqlParameter[] parameter = {
                new SqlParameter("_OWNum",OWNum),
                new SqlParameter("_WDId",WDId),
                new SqlParameter("_CMId",CMId),
                new SqlParameter("_CSId",CSId),
                new SqlParameter("_OWCount",OWCount)
            };
            return DBhelper.DoProc("Proc_OutW", parameter);
        }

        /// <summary>
        /// 调用调拨存储过程
        /// </summary>
        /// <param name="AWNum">调拨单号</param>
        /// <param name="OutWDId">要出库的ID</param>
        /// <param name="InWDId">要入库的ID</param>
        /// <param name="CMId">车辆信息ID</param>
        /// <param name="CSId">车辆类别ID</param>
        /// <param name="AWCount">调拨数量</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Proc_AllotW")]
        public DataTable Proc_AllotW(string AWNum,int OutWDId,int InWDId,int CMId,int CSId,int AWCount)
        {
            SqlParameter[] parameter = {
                new SqlParameter("_AWNum",AWNum),
                new SqlParameter("_OutWDId",OutWDId),
                new SqlParameter("_InWDId",InWDId),
                new SqlParameter("_CMId",CMId),
                new SqlParameter("_CSId",CSId),
                new SqlParameter("_AWCount",AWCount)
            };
            return DBhelper.DoProc("Proc_AllotW", parameter);
        }
    }
}
