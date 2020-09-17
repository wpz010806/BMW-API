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
        public int WTId { get; set; }
        public string WTName { get; set; }
        public int WTCup { get; set; }
        public int WTState { get; set; }
    }
}
