namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalcSurface();

        public abstract double CalcPerimeter();
    }
}
