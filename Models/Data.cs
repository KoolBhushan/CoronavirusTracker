using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.Models
{
    public class Data
    {
        public Summary Summary { get; set; }
        public IList<UnofficialSummary> UnofficialSummary { get; set; }
        public IList<Regional> Regional { get; set; }
    }
}
