namespace Point3D
{
    using System.Text;

    struct Point3D
    {
        private static readonly Point3D start;

        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double  z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double XDimention
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double YDimention
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double ZDimention
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D Start
        {
            get
            {
                return start;
            }
        }

        public override string ToString()
        {
            StringBuilder point = new StringBuilder();

            point.Append("{ " + this.x);
            point.Append(", " + this.y);
            point.Append(", " + this.z);
            point.Append(" }");

            return point.ToString();
        }
    }
}
