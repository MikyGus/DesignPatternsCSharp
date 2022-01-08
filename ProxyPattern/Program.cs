// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("Proxy Pattern");

//Demo1();
Demo2();

static void Demo2()
{
    Console.WriteLine("Proxy pattern, Demo2: Protection Proxy");
    Subject proxy = new ProtectionProxy("Admin");
    proxy.DoSomeWork();

    proxy = new ProtectionProxy("Clint");
    proxy.DoSomeWork();

    proxy = new ProtectionProxy("Sauron");
    proxy.DoSomeWork();
}

static void Demo1()
{
    Subject proxy = new Proxy();
    proxy.DoSomeWork();
}