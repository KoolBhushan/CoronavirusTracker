using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.Models
{
    public class UnofficialSummary
    {
        public string Source { get; set; }
        public int Total { get; set; }
        public int Recovered { get; set; }
        public int Deaths { get; set; }
        public int Active { get; set; }
    }
}
