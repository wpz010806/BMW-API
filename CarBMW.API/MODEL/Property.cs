using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Property")]
    public class Property
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
    }
}
