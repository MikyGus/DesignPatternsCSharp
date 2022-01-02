// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Singleton");
//Console.WriteLine("Tryning to get new instace");
//Singleton firstInstance = Singleton.Instance;

//Console.WriteLine("Tryning to get second instace");
//Singleton secondInstance = Singleton.Instance;

Console.WriteLine($"Value of MyInt: {Singleton.MyInt}");

//SingletonVer2 singletonVer2 = SingletonVer2.Instance;
Console.WriteLine($"Value of MyInt ver2: {SingletonVer2.MyInt}");

SingletonNotThreadSafe SingletonNotThreadSafe = SingletonNotThreadSafe.Instance;

//if (firstInstance.Equals(secondInstance))
//{
//    Console.WriteLine("The first equals the second");
//}
//else
//{
//    Console.WriteLine("The instances are different.");
//}
