using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("InWarehouesInfo")]
    public class InWarehouesInfo
    {
        [Key]
        public int Iid { get; set; }
        public int InWarecode { get; set; }
        public int CKid { get; set; }
        public int CarMessageid { get; set; }
        public int CarSetid { get; set; }
        public int Iinum { get; set; }
        public DateTime Rktime { get; set; }
        public int IISale { get; set; }
    }
}
