﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    [Table("Site")]
    public class Site
    {
        [Key]
        public int Adid { get; set; }
        public string SpecificAddress { get; set; }
    }
}
