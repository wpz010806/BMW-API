using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("RoleInfo")]
    public class RoleInfo
    {
        [Key]
        public int Roleid { get; set; }
        public string RoleName { get; set; }
    }
}
