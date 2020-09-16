using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("CarMessage")]
    public class CarMessage
    {
        [Key]
        public int Iid { get; set; }
        public int Cid { get; set; }
        public string COlour { get; set; }
        public int Clientid { get; set; }
        public int Price { get; set; }
        public int CWarehouseTypeid { get; set; }
    }
}
