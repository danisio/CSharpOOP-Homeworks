namespace Space
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
            this.points.Add(Point3D.Center3D);
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Sorry, Index is out of range");
                }

                return this.points[index];
            }

            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException("Sorry, Index is out of range");
                }

                this.points[index] = value;
            }
        }

        public void AddOnePoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void AddPoints(params Point3D[] point)
        {
            this.points.AddRange(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public void Clear()
        {
            this.points.Clear();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.points);
        }
    }
}
