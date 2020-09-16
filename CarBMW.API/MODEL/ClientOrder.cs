using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("ClientOrder")]
    public class ClientOrder
    {
        [Key]
        public int COid { get; set; }
        public int ClientMessageid { get; set; }
        public int CarMessageid { get; set; }
        public DateTime Ordertime { get; set; }
        public float ClientPrice { get; set; }
        public int OrderSale { get; set; }
    }
}
