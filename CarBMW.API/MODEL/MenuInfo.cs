using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("MenuInfo")]
    public class MenuInfo
    {
        [Key]
        public int Menuid { get; set; }
        public string MenuName { get; set; }
    }
}
