namespace Point3D
{
    using System;
    using System.IO;

    static class PathStorage
    {
        public static void Save(Path path)
        {
            try
            {
                using (StreamWriter save = new StreamWriter(@"..\..\ListOfPoints.txt"))
                {
                    for (int i = 0; i < path.Count; i++)
                    {
                        save.WriteLine(path[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There was a problem saving the path.");
            }
        }

        public static void Load(Path path)
        {
            try
            {
                using (StreamReader load = new StreamReader(@"..\..\ListOfPoints.txt"))
                {
                    string line = load.ReadLine();

                    while (line != null)
                    {
                        int firstCommaIndex = line.IndexOf(',');
                        int secondCommaIndex = line.IndexOf(',', firstCommaIndex + 1);
                        double x = double.Parse(line.Substring(2, firstCommaIndex - 2));
                        double y = double.Parse(line.Substring(firstCommaIndex + 2, secondCommaIndex - firstCommaIndex - 2));
                        double z = double.Parse(line.Substring(secondCommaIndex + 2, line.Length - secondCommaIndex - 4));
                        Point3D point = new Point3D(x, y, z);
                        path.Add(point);

                        line = load.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There was a problem loading the path file.");
            }
        }
    }
}
