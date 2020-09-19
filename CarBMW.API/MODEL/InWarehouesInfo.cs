using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("InWarehouesInfo")]
    public class InWarehouesInfo
    {
        [Key]
        public int IWd { get; set; }
        public int IWNum { get; set; }
        public int WDId { get; set; }
        public int CarMessageid { get; set; }
        public int CarSetid { get; set; }
        public int IWCount { get; set; }
        public DateTime IWTime { get; set; }
        public int IWState { get; set; }
    }
}
