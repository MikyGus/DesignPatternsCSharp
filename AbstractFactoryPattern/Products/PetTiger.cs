namespace AbstractFactoryPattern
{
    internal class PetTiger : ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Tiger: Meow");
        }
    }
}
