using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarBMW.API.MODEL
{
    public class WDandWTView
    {
        [Key]
        public int      WDId        { get; set; }
        public string   WDName      { get; set; }
        public int      WDCount     { get; set; }
        public int      WDState     { get; set; }
        public string   CarMessageId { get; set; }
        public int      WTId        { get; set; }
        public string   WTName      { get; set; }
        public int      WTCup       { get; set; }
        public int      WTState     { get; set; }
    }
}
