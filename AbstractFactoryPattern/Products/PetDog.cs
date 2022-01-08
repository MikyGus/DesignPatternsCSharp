namespace AbstractFactoryPattern
{
    internal class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Dog: Whoff");
        }
    }
}
