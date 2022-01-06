using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Taxa
{
    internal class TaxaBuilder : ITaxaBuilder
    {
        private Taxa _taxa;

        private TaxaBuilder(string taxaNamn, decimal startAvgift, DateTime startDate)
        {
            _taxa = new Taxa()
            {
                TaxaNamn = taxaNamn,
                StartAvgift = startAvgift,
                StartDate = startDate,
            };

        }
        public TaxaBuilder() : this("1-4 Personer", 69M, DateTime.UtcNow) { }
        public TaxaBuilder(Taxa taxaTemplate) : this(taxaTemplate.TaxaNamn, taxaTemplate.StartAvgift, taxaTemplate.StartDate) { }
        //public TaxaBuilder(Taxa taxaTemplate)
        //{
        //    _taxa = taxaTemplate.Clone();
        //}

        public ITaxaBuilder StartAvgift(Decimal startAvgift = 50M)
        {
            _taxa.StartAvgift = startAvgift;
            return this;
        }

        public ITaxaBuilder StartDate(DateTime startDate)
        {
            _taxa.StartDate = startDate;
            return this;
        }

        public ITaxaBuilder TaxaNamn(String taxaNamn = "1-4 Personer")
        {
            _taxa.TaxaNamn = taxaNamn;
            return this;
        }

        public Taxa Create()
        {
            return _taxa;
        }
    }
}
