namespace Point3D
{
    using System;

    static class Distance
    {
        public static string Calculate(Point3D one, Point3D two)
        {
            double x = (one.XDimention - two.XDimention) * (one.XDimention - two.XDimention);
            double y = (one.YDimention - two.YDimention) * (one.YDimention - two.YDimention);
            double z = (one.ZDimention - two.ZDimention) * (one.ZDimention - two.ZDimention);
            double d = Math.Sqrt(x + y + z);

            string output = d.ToString("F2");

            return output;
        }
    }
}
