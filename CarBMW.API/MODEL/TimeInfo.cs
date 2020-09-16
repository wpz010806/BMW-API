using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("TimeInfo")]
    public class TimeInfo
    {
        [Key]
        public int Timeid { get; set; }
        public string TimeName { get; set; }
        public DateTime QDtime { get; set; }
        public DateTime SBtime { get; set; }
        public DateTime QTtime { get; set; }
        public DateTime XBtime { get; set; }
    }
}
