namespace RefactoringSizeClass
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double rotationAngle)
        {
            double absoluteCosRotationAngle = Math.Abs(Math.Cos(rotationAngle));
            double absoluteSinRotationAngle = Math.Abs(Math.Sin(rotationAngle));
            double rotatedWidth = (absoluteCosRotationAngle * size.width) + (absoluteSinRotationAngle * size.height);
            double rotatedHeight = (absoluteSinRotationAngle * size.width) + (absoluteCosRotationAngle * size.height);

            Size rotatedSize = new Size(rotatedWidth, rotatedHeight);

            return rotatedSize;
        }
    }
}
