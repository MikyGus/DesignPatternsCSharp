namespace AbstractFactoryPattern
{
    internal class PetAnimalFactory : IAnimalFactory
    {
        public IDog GetDog() => new PetDog();

        public ITiger GetTiger() => new PetTiger();
    }
}
