using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Motorcycle : IBuilder
    {
        private string _brandName;
        private Product _product;
        public Motorcycle(string brand)
        {
            _product = new Product();
            _brandName = brand;
        }
        public void StartUpOperations()
        {
            _product.Add("_____________________");
        }
        public void BuildBody()
        {
            _product.Add("This is a body of a motorcycle");
        }
        public void InsertWheels()
        {
            _product.Add("2 wheels are added");
        }
        public void AddHeadlights()
        {
            _product.Add("1 headlight is added");
        }

        public void EndOperations()
        {
            _product.Add($"Motorcycle model name: {_brandName}");
            _product.Add("_____________________");
        }

        public Product GetVehicle()
        {
            return _product;
        }


    }
}
