namespace Shapes.Models
{
    using Interfaces;

    public abstract class Shape : IShape
    {
        private int width;
        private int height;

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public abstract double CalculateSurface();
    }
}
