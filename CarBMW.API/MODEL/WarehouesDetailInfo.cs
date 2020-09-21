using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("WarehouesDetailInfo")]
    public class WarehouesDetailInfo
    {
        [Key]
        public int WDId { get; set; }
        public int WTId { get; set; }
        public string WDName { get; set; }
        public int WDCount { get; set; }
        public int WDState { get; set; }
    }
}
