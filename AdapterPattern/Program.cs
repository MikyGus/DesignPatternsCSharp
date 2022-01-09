// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Adapter Pattern");
//Demo1();
Demo2();

static void Demo2()
{
    Console.WriteLine("Only to verify shapes:");
    IRectangle rectangle = new Rectangle(20, 10);
    Console.Write($"Rectangle says: ");
    rectangle.AboutMe();
    ITriangle triangle = new Triangle(20, 10);
    Console.Write($"Triangle says: ");
    triangle.AboutTriangle();

    Console.WriteLine("\nNow using the adapter");
    IRectangle adapter = new AdapterPattern.Demo2.RectangleAdapter(10, 20);
    Console.Write("True fact: ");
    adapter.AboutMe();
}

static void Demo1()
{
    Console.WriteLine("Only to verify area of shapes:");
    IRectangle rectangle = new Rectangle(20, 10);
    Console.WriteLine($"Rectangle area is: {rectangle.CalculateArea()}");
    ITriangle triangle = new Triangle(20,10);
    Console.WriteLine($"Triangle area is: {triangle.CalculateAreaOfTriangle()}");

    Console.WriteLine("\nNow using the adapter.");
    IRectangle adapter = new RectangleAdapter(triangle);
    Console.Write("True fact:");
    adapter.AboutMe();
    Console.WriteLine($"and my area is: {adapter.CalculateArea()}");

    Console.WriteLine("\nNow using a different way.");
    Console.WriteLine($"Area of the triangle using the adapter is: {GetDetails(adapter)}");

    static double GetDetails(IRectangle rectangle)
    {
        rectangle.AboutMe();
        return rectangle.CalculateArea();
    }
}