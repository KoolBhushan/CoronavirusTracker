using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.Models
{
    public class Regional
    {
        public string Loc { get; set; }
        public int ConfirmedCasesIndian { get; set; }
        public int ConfirmedCasesForeign { get; set; }
        public int Discharged { get; set; }
        public int Deaths { get; set; }
        public int TotalConfirmed { get; set; }
    }
}
