using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Car
{
    internal class Ford : BasicCar
    {
        public Ford(string modelName)
        {
            ModelName = modelName;
            basePrice = 500_000;
        }

        public override BasicCar Clone()
        {
            // Shallow copy
            return this.MemberwiseClone() as Ford;
        }
    }
}
