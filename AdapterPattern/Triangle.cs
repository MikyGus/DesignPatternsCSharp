namespace AdapterPattern
{
    internal class Triangle : ITriangle
    {
        private readonly Double _baseLength;
        private readonly Double _height;

        public Triangle(double length, double height)
        {
            _baseLength = length;
            _height = height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("Hi, I'm a Triangle. :)");
        }

        public Double CalculateAreaOfTriangle()
        {
            return 0.5 * _baseLength * _height;
        }
    }
}
