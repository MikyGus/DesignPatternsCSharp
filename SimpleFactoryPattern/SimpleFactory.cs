using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    internal class SimpleFactory
    {
        public IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;
            Console.WriteLine("Enter choice: (0:dog, 1:tiger");
            string b1 = Console.ReadLine();
            if (int.TryParse(b1,out int input))
            {
                Console.WriteLine($"You entered: {input}");
                switch (input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException("Unknown Animal cannot be instantiated.");
                }
            }
            return intendedAnimal;
        }
    }
}
