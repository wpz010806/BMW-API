using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("PurchaseDate")]
    public class PurchaseDate
    {
        [Key]
        public int Pid { get; set; }
        public int CarSetid { get; set; }
        public string Colour { get; set; }
        public float Price { get; set; }
        public int State { get; set; }
        public int Number { get; set; }
        public DateTime PurchasDate { get; set; }
        public int QualityTesting { get; set; }
        public int Wdid { get; set; }
    }
}
