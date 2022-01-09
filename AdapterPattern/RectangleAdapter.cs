namespace AdapterPattern
{
    internal class RectangleAdapter : IRectangle
    {
        private readonly ITriangle _triangle;

        public RectangleAdapter(ITriangle triangle)
        {
            _triangle = triangle;
        }
        public void AboutMe()
        {
            _triangle.AboutTriangle();
        }

        public Double CalculateArea()
        {
            return _triangle.CalculateAreaOfTriangle();
        }
    }
}
