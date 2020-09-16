using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("SignOut")]
    public class SignOut
    {
        [Key]
        public int SOEmtid { get; set; }
        public DateTime SOCheckTime { get; set; }
        public int SOEmid { get; set; }
        public int SOWithStatus { get; set; }
    }
}
