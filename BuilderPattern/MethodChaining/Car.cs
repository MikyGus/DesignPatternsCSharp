using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MethodChaining
{
    internal class Car : IBuilder
    {
        private string _brandName;
        private Product _product;

        public Car(string brand)
        {
            _product = new Product();
            _brandName = brand;
        }

        public IBuilder StartUpOperations(String optionalStartUpMessage = "Making a car for you")
        {
            _product.Add("-----------");
            _product.Add(optionalStartUpMessage);
            _product.Add($"Car model name: {_brandName}");
            return this;
        }

        public IBuilder BuildBody(String optionalBodyType = "Steel")
        {
            _product.Add($"Body type:{optionalBodyType}");
            return this;
        }

        public IBuilder InsertWheels(Int32 optionalNoOfWheels = 4)
        {
            _product.Add($"Wheels: {optionalNoOfWheels.ToString()}");
            return this;
        }

        public IBuilder AddHeadlights(Int32 optionalNoOfHeadlights = 2)
        {
            _product.Add($"Headlights: {optionalNoOfHeadlights.ToString()}");
            return this;
        }

        public IBuilder EndOperations(String optionalEndMessage = "Car construction is completed")
        {
            _product.Add(optionalEndMessage);
            return this;
        }

        public Product ConstructCar()
        {
            return _product;
        }
    }
}
