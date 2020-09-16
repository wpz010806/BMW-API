using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("OutWareInfo")]
    public class OutWareInfo
    {
        [Key]
        public int OIid { get; set; }
        public string OIcode { get; set; }
        public int CKid { get; set; }
        public int CarMessageid { get; set; }
        public int CarSetid { get; set; }
        public int Iinum { get; set; }
        public DateTime CKtime { get; set; }
        public int OISale { get; set; }
        public int CWarehouesid { get; set; }
    }
}
