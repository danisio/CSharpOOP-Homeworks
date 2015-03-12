namespace Space
{
    using System;

    public static class Distance
    {
        public static double Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            double result = 0;

            double x = (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X);
            double y = (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y);
            double z = (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z);

            result = Math.Sqrt(x + y + z);

            return result;
        }
    }
}
