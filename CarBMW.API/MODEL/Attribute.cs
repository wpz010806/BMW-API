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
        public int Caid { get; set; }
        public int Commodityid { get; set; }
        public int Atid { get; set; }
        public string PropertyName { get; set; }
    }
}
