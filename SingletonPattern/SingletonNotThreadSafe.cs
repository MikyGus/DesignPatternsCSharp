namespace SingletonPattern
{
    internal class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe _instance;
        private SingletonNotThreadSafe() { Console.WriteLine("pritave ctor Not threadSafe!"); }
        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonNotThreadSafe();
                }
                return _instance;
            }
        }
    }
}
