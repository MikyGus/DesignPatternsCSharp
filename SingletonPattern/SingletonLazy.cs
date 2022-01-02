namespace SingletonPattern
{
    internal sealed class SingletonLazy
    {
        delegate SingletonLazy SingletonDelegateWithNoParameter();
        static SingletonDelegateWithNoParameter _myDelegate = MakeSingletonInstance;

        static Func<SingletonLazy> _myFuncDelegate = MakeSingletonInstance;

        // Only use *one* of these: Lambda, FuncDelegate, Delegate
        private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(() => {
            Console.WriteLine("Creating a new SingletonLaze instance");
            return new SingletonLazy();
            });
        //private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(
        //    _myFuncDelegate()
        //    //_myDelegate() 
        //    );

        private static SingletonLazy MakeSingletonInstance()
        {
            Console.WriteLine("Creating a new SingletonLaze instance");
            return new SingletonLazy();
        }

        private SingletonLazy() { }

        public static SingletonLazy Instance
        {
            get 
            {
                Console.WriteLine("Getting a SingletonLaze instance");
                return _instance.Value; 
            }
        }
    }
}
