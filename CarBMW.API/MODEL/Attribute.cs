using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Attribute")]
    public class Attribute
    {
        [Key]
        public int AId { get; set; }
        public int Commodityid { get; set; }
        public string AName { get; set; }
        public int PropertyId { get; set; }
    }
}
