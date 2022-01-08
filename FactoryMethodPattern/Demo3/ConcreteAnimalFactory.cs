namespace FactoryMethodPattern.Demo3
{
    internal class ConcreteAnimalFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal(String animalType)
        {
            if (animalType.Contains("dog"))
            {
                return new Dog();
            }
            else if (animalType.Contains("tiger"))
            {
                return new Tiger();
            }
            throw new ArgumentException("You need to pass either 'dog' or 'tiger' as an argument!");
        }
    }
}
