using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
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
        public void StartUpOperations()
        {
            _product.Add("-----------");
            _product.Add($"Car model name: {_brandName}");
        }

        public void BuildBody()
        {
            _product.Add("This is a body of a Car");
        }
        public void InsertWheels()
        {
            _product.Add("4 wheels are added");
        }
        public void AddHeadlights()
        {
            _product.Add("2 Headlights are added");
        }


        public void EndOperations()
        {
            _product.Add("-----------");
        }

        public Product GetVehicle()
        {
            return _product;
        }


    }
}
