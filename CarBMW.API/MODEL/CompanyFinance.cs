using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("CompanyFinance")]
    public class CompanyFinance
    {
        [Key]
        public int CFid { get; set; }
        public string CFName { get; set; }
        public float Cfzprice { get; set; }
    }
}
