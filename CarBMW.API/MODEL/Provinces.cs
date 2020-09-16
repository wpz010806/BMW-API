using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Provinces")]
    public class Provinces
    {
        [Key]
        public int Prid { get; set; }
        public string PName { get; set; }
        public int Sbid { get; set; }
    }
}
