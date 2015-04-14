namespace Point3D
{
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> points;
        private int count;

        public Path()
        {
            this.points = new List<Point3D>();
            this.count = new int();
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this.points[index];
            }
            set
            {
                this.points[index] = value;
            }
        }

        public void Add(Point3D point)
        {
            this.points.Add(point);
            this.count++;
        }

        public void Remove(int index)
        {
            if (index < this.points.Count)
            {
                this.points.RemoveAt(index);
                this.count--;
            }
        }

        public override string ToString()
        {
            
            return string.Join("\n", points);
        }
    }
}
