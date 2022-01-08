namespace DecoratorPattern
{
    internal class ConcreteHome : AbstractHome
    {
        public ConcreteHome()
        {
            AdditionalPrice = 0;
        }
        public override void MakeHome()
        {
            Console.WriteLine("House is constructed. Price for this is $10.000");
        }
    }
}
