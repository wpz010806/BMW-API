using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("StaffSign")]
    public class StaffSign
    {
        [Key]
        public int Sempid { get; set; }
        public int Semid { get; set; }
        public DateTime SCheckTime { get; set; }
        public int SCheckStatus { get; set; }
    }
}
