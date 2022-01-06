using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Taxa
{
    internal class Taxa
    {
        public DateTime StartDate { get; set; }
        public string TaxaNamn { get; set; } = string.Empty;
        public decimal StartAvgift { get; set; }

        //public Taxa Clone()
        //{
        //    // Shallow copy
        //    return (Taxa)MemberwiseClone();
        //}

        //public decimal KrPerKilometer { get; init; }
        //public decimal KrPerTimme { get; init; }
        //public TaxaFilterAttr.Car Car { get; init; }
        //public TaxaFilterAttr.Customer Customer { get; init; }
        //public TaxaFilterAttr.Distance Distance { get; init; }
        //public TaxaFilterAttr.Time Time { get; init; }
    }
}
