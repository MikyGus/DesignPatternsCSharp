using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Product
    {
        private LinkedList<string> _parts;
        public Product()
        {
            _parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            _parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below: ");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
