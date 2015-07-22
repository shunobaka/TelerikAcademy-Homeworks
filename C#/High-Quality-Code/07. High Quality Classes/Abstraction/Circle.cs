﻿namespace Abstraction
{
    using System;

    public class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get 
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The radius of the circle cannot be zero or negative!");
                }

                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
