using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        public int Urid { get; set; }
        public int UserInfoid { get; set; }
        public int RoleInfoid { get; set; }
    }
}
