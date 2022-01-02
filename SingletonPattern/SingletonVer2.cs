namespace SingletonPattern
{
    internal sealed class SingletonVer2
    {
        private static readonly SingletonVer2 _instance = new SingletonVer2();

        private SingletonVer2()
        {
            Console.WriteLine("My private ctor");
        }
        public static SingletonVer2 Instance
        {
            get
            {
                return _instance;
            }
        }

        public static int MyInt = 26;
    }
}
