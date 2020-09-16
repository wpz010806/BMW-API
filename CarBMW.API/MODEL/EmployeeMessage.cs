using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("EmployeeMessage")]
    public class EmployeeMessage
    {
        [Key]
        public int Emid { get; set; }
        public string EMCode { get; set; }
        public int Departmentid { get; set; }
        public string EMName { get; set; }
        public bool Emsex { get; set; }
        public int Emage { get; set; }
        public string EMCard { get; set; }
        public int Emphone { get; set; }
        public string EMAddress { get; set; }
    }
}
