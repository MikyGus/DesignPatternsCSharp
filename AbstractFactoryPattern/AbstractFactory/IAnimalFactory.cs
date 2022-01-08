namespace AbstractFactoryPattern
{
    internal interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
