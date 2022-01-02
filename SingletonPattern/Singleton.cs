using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

internal sealed class Singleton
{
    private static readonly Singleton _instance;
    private static int _totalInstances;

    private Singleton()
    {
        Console.WriteLine("Private ctor is called");
        Console.WriteLine("Private ctor is exited");
    }

    static Singleton()
    {
        Console.WriteLine("Static ctor is called");
        _instance = new Singleton();
        _totalInstances++;
        Console.WriteLine($"Singleton is created. Total number is: {_totalInstances}");
        Console.WriteLine("Static ctor is exited");
    }

    public static Singleton Instance => Singleton._instance;

    public static int MyInt = 25;
}
