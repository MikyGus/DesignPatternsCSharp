namespace DecoratorPattern
{
    internal class FloorDecorator : AbstractDecorator
    {
        public FloorDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 2500;
        }

        public override void MakeHome()
        {
            base.MakeHome();
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine($"-Additional floor added. Pay ${AdditionalPrice} for it.");
        }
    }
}
