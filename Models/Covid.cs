using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.Models
{
    public class Covid
    {
        public bool Success { get; set; }
        public Data Data { get; set; }
        public DateTime LastRefreshed { get; set; }
        public DateTime LastOriginUpdate { get; set; }
    }
}
