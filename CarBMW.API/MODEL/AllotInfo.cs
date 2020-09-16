using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("AllotInfo")]
    public class AllotInfo
    {
        [Key]
        public int Awid { get; set; }
        public int EmployeeMessageid { get; set; }
        public int Departmentid { get; set; }
        public int ASignTimes { get; set; }
        public int AWithdrawalTimes { get; set; }
        public int ALeaveTimes { get; set; }
        public string Acategory { get; set; }
    }
}
