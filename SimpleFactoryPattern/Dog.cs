using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    internal class Dog : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("Dog: Whoff");
        }
    }
}
