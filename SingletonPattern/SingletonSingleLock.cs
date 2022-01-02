using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal sealed class SingletonSingleLock
    {
        private static volatile SingletonSingleLock _instance;
        private static object _lockObject = new object();

        private SingletonSingleLock()
        {
            Console.WriteLine("Private ctor SingletonSingleLock");
        }

        public static SingletonSingleLock Instance
        {
            get
            {
                // Locking first
                lock (_lockObject)
                {
                    // Single check
                    if (_instance == null)
                    {
                        _instance = new SingletonSingleLock();
                    }
                }
                return _instance;
            }
        }
    }
}
