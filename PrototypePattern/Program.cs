// See https://aka.ms/new-console-template for more information
using PrototypePattern.Employees;
using Car = PrototypePattern.Car;

Console.WriteLine("Prototype Pattern");
//Demo1();
//Demo2();
Employee();

static void Employee()
{
    Console.WriteLine("Shallow copy vs Deep copy");
    EmployeeAddress initialAdress = new EmployeeAddress("21, abc Road, USA");
    Employee emp = new Employee(1, "John", initialAdress);

    Console.WriteLine("The original object is emp1 which is as follows:");
    Console.WriteLine(emp);

    Console.WriteLine();
    Console.WriteLine("Making clone");
    Employee empClone = (Employee)emp.Clone();
    Console.WriteLine("Emp clone is as follows");
    Console.WriteLine(empClone);

    Console.WriteLine();
    Console.WriteLine("Changing values of clone");
    empClone.Id = 10;
    empClone.Name = "Miky";
    empClone.EmployeeAddress.Address = "221, xyz Road, Canada";

    Console.WriteLine();
    Console.WriteLine("Emp1 is now:");
    Console.WriteLine(emp);
    Console.WriteLine("EmpClone is now");
    Console.WriteLine(empClone);
}

static void Demo2()
{
    Console.WriteLine("CarFactory");
    Car.CarFactory carFactory = new Car.CarFactory();

    Console.WriteLine("Start Cloning cars");
    // Nano clone
    Car.BasicCar basicCar = carFactory.GetNano();
    basicCar.onRoadPrice = basicCar.basePrice + Car.BasicCar.SetAdditionalPrice();
    Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

    // Ford clone
    basicCar = carFactory.GetFord();
    basicCar.onRoadPrice = basicCar.basePrice + Car.BasicCar.SetAdditionalPrice();
    Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");
}

static void Demo1()
{
    Console.WriteLine("Base or Original Copy");
    Car.BasicCar nano = new Car.Nano("Green Nano");
    Car.BasicCar ford = new Car.Ford("Yellow Ford");


    Car.BasicCar basicCar;
    // Nano clone
    basicCar = nano.Clone();
    basicCar.onRoadPrice = basicCar.basePrice + Car.BasicCar.SetAdditionalPrice();
    Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

    // Ford clone
    basicCar = ford.Clone();
    basicCar.onRoadPrice = basicCar.basePrice + Car.BasicCar.SetAdditionalPrice();
    Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");
}


