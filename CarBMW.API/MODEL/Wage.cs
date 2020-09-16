using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Wage")]
    public class Wage
    {
        [Key]
        public int Wageid { get; set; }
        public float Wages { get; set; }
        public int Emid { get; set; }
    }
}
