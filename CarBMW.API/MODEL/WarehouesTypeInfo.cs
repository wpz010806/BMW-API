using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("WarehouesTypeInfo")]
    public class WarehouesTypeInfo
    {
        [Key]
        public int WTid { get; set; }
        public string WTName { get; set; }
        public int Wtcapacity { get; set; }
        public int WTSale { get; set; }
    }
}
