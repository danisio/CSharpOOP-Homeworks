namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
            : base(side, height)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
