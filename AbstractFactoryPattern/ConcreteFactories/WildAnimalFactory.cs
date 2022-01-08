namespace AbstractFactoryPattern
{
    internal class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog() => new WildDog();

        public ITiger GetTiger() => new WildTiger();
    }
}
