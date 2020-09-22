using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("CarAndWareInfo")]
    public class CarAndWareInfo
    {
        [Key]
        public int CandWId { get; set; }
        public int lid { get; set; }
        public int WDId { get; set; }
    }
}
