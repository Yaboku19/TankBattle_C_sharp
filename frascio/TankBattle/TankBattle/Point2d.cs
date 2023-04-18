namespace TankBattle
{
    public class Point2d
    {
        public double X {get; }
        public double Y {get; }

        public Point2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2d sum(Point2d point) => new Point2d(this.X + point.X, this.Y + point.Y);

        public Point2d multiply(double multiplier) => new Point2d(this.X * multiplier, this.Y * multiplier);

        public double getMagnitude() =>  Math.Sqrt(this.X * this.X + this.Y * this.Y);
    }
}