namespace Shapes.Models
{
    using Interfaces;

    public class Square : Shape, IShape
    {
        public Square(int side)
            : base(side, side)
        {

        }

        public override double CalculateSurface()
        {
            return base.Height * base.Height;
        }

        public override string ToString()
        {
            return string.Format("Square({0}):", base.Width);
        }
    }
}
