using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("AllotWarehouesInfo")]
    public class AllotWarehouesInfo
    {
        [Key]
        public int AWId { get; set; }
        public string AWNum { get; set; }
        public int OutWDId { get; set; }
        public int InWDId { get; set; }
        public int AWCount { get; set; }
        public DateTime AWDate { get; set; }
        public int AWState { get; set; }
    }
}
