using CoronovirusTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.ViewModels
{
    public class SalesViewModel
    {
        public List<Sales> Sales { get; set; }
        public SalesViewModel()
        {
            Sales = new List<Sales>()
            {
                new Sales { Year = "2015", ProductA = 300, ProductB = 500 },
                new Sales { Year = "2016", ProductA = 400, ProductB = 600 },
                new Sales { Year = "2017", ProductA = 500, ProductB = 600 },
                new Sales { Year = "2018", ProductA = 700, ProductB = 800 },
                new Sales { Year = "2019", ProductA = 250, ProductB = 400 },
                new Sales { Year = "2020", ProductA = 450, ProductB = 150 },
                new Sales { Year = "2021", ProductA = 582, ProductB = 685 }
            };
        }

    }
}
