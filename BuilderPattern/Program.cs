// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using MethodChaining = BuilderPattern.MethodChaining;

Console.WriteLine("Builder pattern");
//Demo1();
MethodChaining();


static void MethodChaining()
{
    MethodChaining.Product customCar;
    customCar = new MethodChaining.Car("Suzuki Swift").StartUpOperations()
        .AddHeadlights(6)
        .InsertWheels()
        .BuildBody("Plastic")
        .EndOperations("Suzuki construction completed")
        .ConstructCar();
    customCar.Show();

    MethodChaining.Product customCar2 = new MethodChaining.Car("Sedan")
        .InsertWheels(7)
        .AddHeadlights(6)
        .StartUpOperations("Sedan creation in progress")
        .BuildBody()
        .EndOperations()
        .ConstructCar();
    customCar2.Show();

}
static void Demo1()
{
    Director director = new Director();

    IBuilder b1 = new Car("Ford");
    IBuilder b2 = new Motorcycle("Honda");

    director.Construct(b1);
    Product p1 = b1.GetVehicle();
    p1.Show();

    director.Construct(b2);
    Product p2 = b2.GetVehicle();
    p2.Show();
}


