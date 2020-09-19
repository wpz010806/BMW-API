using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Reserve")]
    public class Reserve
    {
        [Key]
        public int Clientid { get; set; }
        public int ClientSex { get; set; }
        public string ClientName { get; set; }
        public int Clientphone { get; set; }
        public string ClientCard { get; set; }
        public string ClientAddress { get; set; }
    }
}
