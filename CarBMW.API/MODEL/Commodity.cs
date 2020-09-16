using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Commodity")]
    public class Commodity
    {
        [Key]
        public int Cmid { get; set; }
        public int Stock { get; set; }
        public string CommName { get; set; }
    }
}
