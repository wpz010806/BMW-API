using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("MyshoppingCar")]
    public class MyshoppingCar
    {
        [Key]
        public int Sid { get; set; }
        public string MyName { get; set; }
        public string ComColour { get; set; }
        public int CommodityPrice { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string CarConfigure { get; set; }
        public int Uid { get; set; }
        public DateTime AddDate { get; set; }
    }
}
