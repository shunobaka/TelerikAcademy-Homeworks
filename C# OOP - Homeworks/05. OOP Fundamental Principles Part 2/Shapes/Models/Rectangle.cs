namespace Shapes.Models
{
    using Interfaces;

    public class Rectangle : Shape, IShape
    {
        public Rectangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return (base.Height * base.Width);
        }

        public override string ToString()
        {
            return string.Format("Rectangle({0},{1}):", base.Width, base.Height);
        }
    }
}
