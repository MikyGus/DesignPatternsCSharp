using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Car
{
    internal class Nano : BasicCar
    {
        public Nano(string modelName)
        {
            ModelName = modelName;
            basePrice = 100_000;
        }

        public override BasicCar Clone()
        {
            // Shallow copy
            return this.MemberwiseClone() as Nano;
        }
    }
}
