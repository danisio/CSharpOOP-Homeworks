namespace Space
{
    using System;

    public class TestAll
    {
        public static void Main()
        {
            // add test path
            Path path = new Path();

            // add some test points
            Point3D firstPoint = new Point3D(2, 7, 4);
            Point3D secondPoint = new Point3D(2, 4, 1);

            // add the 2 points to the path
            path.AddOnePoint(firstPoint);
            path.AddOnePoint(secondPoint);

            // save the path to a file
            PathStorage.SavePath(path, "..\\..\\output.txt");

            // load a path from a file
            Path newTestPath = PathStorage.LoadPath("..\\..\\input.txt");

            // save the loaded path to a file
            PathStorage.SavePath(newTestPath, "..\\..\\output.txt");

            // print both paths
            Console.WriteLine(path.ToString());
            Console.WriteLine(newTestPath.ToString());

            // calculate the distance
            var result = Distance.Calculate(firstPoint, secondPoint);

            // print it
            Console.WriteLine("The distance between point {0} and point {1} = {2:F2}", firstPoint.ToString(), secondPoint.ToString(), result);

            // print the center point (static field)
            Console.WriteLine("Center Point: " + Point3D.Center3D.ToString());
        }
    }
}
