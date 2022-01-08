// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

Console.WriteLine("Abstract Factory Pattern");
Demo1();

static void Demo1()
{
    Console.WriteLine("Demo1:");
    Console.WriteLine("*** Wild things ***");
    IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
    IDog dog = animalFactory.GetDog();
    ITiger tiger = animalFactory.GetTiger();
    dog.AboutMe();
    tiger.AboutMe();

    Console.WriteLine();
    Console.WriteLine("*** Not so wild things ***");
    animalFactory = FactoryProvider.GetAnimalFactory("pet");
    dog = animalFactory.GetDog();
    tiger = animalFactory.GetTiger();
    dog.AboutMe();
    tiger.AboutMe();

}