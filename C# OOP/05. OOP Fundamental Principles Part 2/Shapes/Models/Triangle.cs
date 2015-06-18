namespace Shapes.Models
{
    using Interfaces;

    public class Triangle : Shape, IShape
    {
        public Triangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (base.Height * base.Width / 2);
        }

        public override string ToString()
        {
            return string.Format("Triangle({0},{1}):", base.Width, base.Height);
        }
    }
}
