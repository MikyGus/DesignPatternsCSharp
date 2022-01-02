using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal sealed class SingletonDoubleCheckLock
    {
        private static volatile SingletonDoubleCheckLock _instance;
        private static object _instanceLock = new object();

        private SingletonDoubleCheckLock() 
        { 
            Console.WriteLine("Private ctor SingletonVer3"); 
        }

        public static SingletonDoubleCheckLock Instance
        {
            get
            {
                // First check
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        // Second check
                        if (_instance == null)
                        {
                            _instance = new SingletonDoubleCheckLock();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
