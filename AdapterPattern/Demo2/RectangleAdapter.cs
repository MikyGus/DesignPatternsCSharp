namespace AdapterPattern.Demo2
{
    internal class RectangleAdapter : Triangle, IRectangle
    {
        public RectangleAdapter(Double length, Double height) : base(length, height)
        {
        }

        public void AboutMe()
        {
            AboutTriangle();
        }

        public Double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
