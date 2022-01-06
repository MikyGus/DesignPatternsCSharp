using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Taxa
{
    internal interface ITaxaBuilder
    {
        ITaxaBuilder StartDate(DateTime startDate);
        ITaxaBuilder TaxaNamn(string taxaNamn = "1-4 Personer");
        ITaxaBuilder StartAvgift(decimal startAvgift = 50M);
        Taxa Create();
    }
}

//public DateTime StartDate { get; set; }
//public string TaxaNamn { get; init; }
//public decimal StartAvgift { get; init; }
//public decimal KrPerKilometer { get; init; }
//public decimal KrPerTimme { get; init; }
//public TaxaFilterAttr.Car Car { get; init; }
//public TaxaFilterAttr.Customer Customer { get; init; }
//public TaxaFilterAttr.Distance Distance { get; init; }
//public TaxaFilterAttr.Time Time { get; init; }


//IBuilder StartUpOperations(string optionalStartUpMessage = "Making a car for you");
//IBuilder BuildBody(string optionalBodyType = "Steel");
//IBuilder InsertWheels(int optionalNoOfWheels = 4);
//IBuilder AddHeadlights(int optionalNoOfHeadlights = 2);
//IBuilder EndOperations(string optionalEndMessage = "Car construction is completed");
//Product ConstructCar();