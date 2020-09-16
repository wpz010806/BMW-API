using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("RoleMenu")]
    public class RoleMenu
    {
        [Key]
        public int Rmid { get; set; }
        public int Roleid { get; set; }
        public int MenuInfoid { get; set; }
        public int RMSale { get; set; }
    }
}
