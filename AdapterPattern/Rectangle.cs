namespace AdapterPattern
{
    internal class Rectangle : IRectangle
    {
        private double _length;
        public double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public void AboutMe()
        {
            Console.WriteLine("Hi, I'm a Rectangle!");
        }

        public Double CalculateArea()
        {
            return _length * _width;
        }
    }
}
