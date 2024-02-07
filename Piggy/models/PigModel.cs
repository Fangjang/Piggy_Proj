using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy.models
{
    public class PigModel
    {
        public int pigid { get; set; }
        public double pigage { get; set; }
        public double pigweight { get; set; }
        public string? pigsex { get; set; }
        public bool? isSold { get; set; }
        public double? soldPrice { get; set; }
        public DateTime? soldDate { get; set; }
        public decimal? PigPrice { get; set; }

    }
}
