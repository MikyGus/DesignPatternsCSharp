using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Car
{
    internal abstract class BasicCar
    {
        public int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }

        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int price = random.Next(200_000, 500_000);
            return price;
        }

        public abstract BasicCar Clone();
    }
}
