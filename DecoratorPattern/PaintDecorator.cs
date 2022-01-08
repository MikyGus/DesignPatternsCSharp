namespace DecoratorPattern
{
    internal class PaintDecorator : AbstractDecorator
    {
        public PaintDecorator(AbstractHome home) : base(home)
        {
            AdditionalPrice = 5000;
        }
        public override void MakeHome()
        {
            base.MakeHome();
            PaintHome();
        }

        private void PaintHome()
        {
            Console.WriteLine($"--Painting done. Pay additional ${AdditionalPrice} for it.");
        }
    }
}
