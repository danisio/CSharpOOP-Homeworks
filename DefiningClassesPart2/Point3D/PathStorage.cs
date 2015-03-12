namespace Space
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, true);

            using (writer)
            {
                writer.Write(string.Format("{0}\n", path));
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            string content = File.ReadAllText(filePath);
            string[] points = content.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < points.Length; i++)
            {
                double[] coordinates = points[i].Split(
                    new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                path.AddPoints(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
            }

            return path;
        }
    }
}
