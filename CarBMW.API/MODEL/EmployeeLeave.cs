using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("EmployeeLeave")]
    public class EmployeeLeave
    {
        [Key]
        public int ELid { get; set; }
        public int EmployeeMessageid { get; set; }
        public string ReasonsLeave { get; set; }
        public DateTime ELStartDate { get; set; }
        public DateTime ELEndTime { get; set; }
        public int LeaveStatus { get; set; }
    }
}
