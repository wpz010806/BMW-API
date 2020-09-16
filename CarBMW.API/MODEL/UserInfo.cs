using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        public int Uid { get; set; }
        public string Username { get; set; }
        public string UserPwd { get; set; }
    }
}
