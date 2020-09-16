using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("EmployeeSalary")]
    public class EmployeeSalary
    {
        [Key]
        public int Esid { get; set; }
        public int EmployeeMessageid { get; set; }
        public int ClientMessageid { get; set; }
        public int ClientOrderid { get; set; }
        public int Wageid { get; set; }
    }
}
