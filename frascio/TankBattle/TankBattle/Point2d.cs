namespace TankBattle
{
    /// <summary>
    /// Represents a point in the map.
    /// </summary>
    public class Point2d
    {
        public double X {get; }
        public double Y {get; }


        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public Point2d(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Sum this with the point passed.
        /// </summary>
        /// <param name="point">the point to sum</param>
        /// <returns>the sum of the 2 points</returns>
        public Point2d sum(Point2d point) => new Point2d(this.X + point.X, this.Y + point.Y);

        /// <summary>
        /// Multiply this with the point passed.
        /// </summary>
        /// <param name="multiplier">the point to multiply</param>
        /// <returns>multiplication of the two points</returns>
        public Point2d multiply(double multiplier) => new Point2d(this.X * multiplier, this.Y * multiplier);

        /// <summary>
        /// Pythagorean theorem between the coordinates.
        /// </summary>
        /// <returns>the result</returns>
        public double getMagnitude() =>  Math.Sqrt(this.X * this.X + this.Y * this.Y);
    }
}