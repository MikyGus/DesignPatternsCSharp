using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    internal class Tiger : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Tiger: Rarr...");
        }
    }
}
