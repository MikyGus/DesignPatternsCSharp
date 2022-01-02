using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Car
{
    internal class CarFactory
    {
        // Non lazy
        //private readonly BasicCar _nano, _ford;

        // Lazy
        private readonly Lazy<Nano> _nano;
        private readonly Lazy<Ford> _ford;

        public CarFactory()
        {
            // Non lazy
            //_nano = new Nano("Green Nano");
            //_ford = new Ford("Yellow Form");

            // Lazy
            _nano = new(() =>
            {
                Console.WriteLine("Initializes Nano Model");
                return new Nano("Nano modell");
            });

            _ford = new(() =>
            {
                Console.WriteLine("Initializes Ford Model");
                return new Ford("Yellow Ford");
            });
        }

        // Non lazy
        //internal BasicCar GetNano() => _nano;
        //internal BasicCar GetFord() => _ford;

        // Lazy
        internal BasicCar GetNano() => _nano.Value;
        internal BasicCar GetFord() => _ford.Value;
    }
}
