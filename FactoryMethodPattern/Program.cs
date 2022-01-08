// See https://aka.ms/new-console-template for more information
using FactoryMethodPattern;
using Demo3 = FactoryMethodPattern.Demo3;

Console.WriteLine("Factory Method Pattern");
//Demo1();
//Demo2();
Demo3();

static void Demo3()
{
    Demo3.AnimalFactory animalFactory = new Demo3.ConcreteAnimalFactory();
    IAnimal tiger = animalFactory.CreateAnimal("tiger");
    tiger.AboutMe();

    IAnimal dog = animalFactory.CreateAnimal("dog");
    dog.AboutMe();
}

static void Demo2()
{
    AnimalFactory tigerFactory = new TigerFactory();
    IAnimal tiger = tigerFactory.MakeAnimal();

    AnimalFactory dogFactory = new DogFactory();
    IAnimal dog = dogFactory.MakeAnimal();
}
static void Demo1()
{
    //Demo 1
    AnimalFactory tigerFactory = new TigerFactory();
    IAnimal tiger = tigerFactory.CreateAnimal();
    tiger.AboutMe();

    AnimalFactory dogFactory = new DogFactory();
    IAnimal dog = dogFactory.CreateAnimal();
    dog.AboutMe();
}

