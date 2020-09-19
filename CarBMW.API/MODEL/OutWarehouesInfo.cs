using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("OutWarehouesInfo")]
    public class OutWarehouesInfo
    {
        [Key]
        public int OWId { get; set; }
        public string OWNum { get; set; }
        public int WDId { get; set; }
        public int CarMessageid { get; set; }
        public int CarSetid { get; set; }
        public int OWCount { get; set; }
        public DateTime OWTime { get; set; }
        public int OWState { get; set; }
    }
}
