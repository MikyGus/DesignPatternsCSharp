using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MethodChaining
{
    internal interface IBuilder
    {
        IBuilder StartUpOperations(string optionalStartUpMessage = "Making a car for you");
        IBuilder BuildBody(string optionalBodyType = "Steel");
        IBuilder InsertWheels(int optionalNoOfWheels = 4);
        IBuilder AddHeadlights(int optionalNoOfHeadlights = 2);
        IBuilder EndOperations(string optionalEndMessage = "Car construction is completed");
        Product ConstructCar();
    }
}
