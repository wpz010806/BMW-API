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
        public int Wdid { get; set; }
        public int WarehouseTypeInfoid { get; set; }
        public int CarMessageid { get; set; }
        public int CarSetid { get; set; }
        public int WDnum { get; set; }
        public int WDSale { get; set; }
    }
}
