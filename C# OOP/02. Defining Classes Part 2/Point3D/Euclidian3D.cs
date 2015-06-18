namespace Point3D
{
    using System;

    class Euclidian3D
    {
        static void Main()
        {
            Point3D point = new Point3D(-7, -4, 3);                   // Creates two points
            Point3D pointtwo = new Point3D(17, 6, 2.5);               // 
            Path path = new Path();                                   // Creates a path

            Console.WriteLine(Point3D.Start);                         // Prints starting point of the coordination system
            Console.WriteLine(Distance.Calculate(point, pointtwo));   // Prints distance between points

            PathStorage.Load(path);                                   // Loads points into path

            Console.WriteLine(path);                                  // Prints path

            PathStorage.Save(path);                                   // Saves the path back to the file
        }
    }
}
