using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonNotSealed
    {
        private static readonly SingletonNotSealed _instance = new SingletonNotSealed();
        private static int _totalInstances;

        private SingletonNotSealed()
        {
            Console.WriteLine("Private SingletonNotSealed ctor is called");
            _totalInstances++;
            Console.WriteLine($"Singleton is created. Total number is: {_totalInstances}");
            Console.WriteLine("Private SingletonNotSealed ctor is exited");
        }

        public static SingletonNotSealed Instance => SingletonNotSealed._instance;

        // "Sealed" guard this scenario
        public class NestedDerived : SingletonNotSealed {}

        public static int MyInt = 25;
    }
}
