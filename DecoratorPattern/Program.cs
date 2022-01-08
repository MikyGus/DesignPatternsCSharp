// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Decorator Pattern");


Console.WriteLine("Scenario 1:");
Console.WriteLine("Building home. Adding floor and then painting it.");

AbstractHome home = new ConcreteHome();
Console.WriteLine("Current bill breakups are as follows:");
home.MakeHome();

home = new FloorDecorator(home);
Console.WriteLine("\nFloor added. Current bill breakups are as follows:");
home.MakeHome();

home = new PaintDecorator(home);
Console.WriteLine("\nPainted the home. Current bill breakups are as follows:");
home.MakeHome();



Console.WriteLine("\n\nScenario 2:");
Console.WriteLine("Building home. Painting it and then adding two floors.");

home = new ConcreteHome();
Console.WriteLine("Current bill breakups are as follows:");
home.MakeHome();

home = new PaintDecorator(home);
Console.WriteLine("\nPainted the home. Current bill breakups are as follows:");
home.MakeHome();

home = new FloorDecorator(home);
Console.WriteLine("\nFloor added. Current bill breakups are as follows:");
home.MakeHome();

home = new FloorDecorator(home);
Console.WriteLine("\nFloor added. Current bill breakups are as follows:");
home.MakeHome();
