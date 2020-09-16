using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("DepartmentInfo")]
    public class DepartmentInfo
    {
        [Key]
        public int DIid { get; set; }
        public string DName { get; set; }
    }
}
