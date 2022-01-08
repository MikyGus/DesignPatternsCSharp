// See https://aka.ms/new-console-template for more information
using SimpleFactoryPattern;

Console.WriteLine("Simple Factory pattern");

SimpleFactory simpleFactory = new SimpleFactory();
IAnimal prefferedType = simpleFactory.CreateAnimal();
prefferedType.AboutMe();