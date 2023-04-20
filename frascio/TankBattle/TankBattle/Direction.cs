namespace TankBattle
{
    /// <summary>
    /// Represents a class with the possible Directions in the game.
    /// </summary>
    public sealed class Direction
    {
        public double X {get; }
        public double Y {get; }

        /// <summary>
        /// Gets the Point2d associated to the Direction.
        /// </summary>
        public Point2d Vector => new (this.X, this.Y);


        public static readonly Direction UP = new(0, 1);
        public static readonly Direction DOWN = new(0, -1);
        public static readonly Direction LEFT = new(-1, 0);
        public static readonly Direction RIGTH = new(1, 0);
        public static readonly Direction NONE = new(0, 0);

        /// <param name="X">x direciton</param>
        /// <param name="y">y direction</param>
        private Direction(double X, int y)
        {
            this.X = X;
            this.Y = y;
        }
    }
}