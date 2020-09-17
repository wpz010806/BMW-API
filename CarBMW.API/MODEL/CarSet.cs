using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("CarSet")]
    public class CarSet
    {
        [Key]//12345
        public int Cid { get; set; }
        public string Series { get; set; }
    }
}
