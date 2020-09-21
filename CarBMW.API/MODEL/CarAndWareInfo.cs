using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("CarAndWareInfo")]
    public class CarAndWareInfo
    {
        public int lid { get; set; }
        public int WDId { get; set; }
    }
}
