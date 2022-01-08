using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal abstract class AnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            Console.WriteLine("Making Animal");
            IAnimal animal = CreateAnimal();
            animal.AboutMe();
            return animal;
        }
        public abstract IAnimal CreateAnimal();
    }
}
