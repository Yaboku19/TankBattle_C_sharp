namespace TankBattle
{
    /// <summary>
    /// Represents the values that every GameObject has.
    /// </summary>
    public class Transform
    {
        /// <summary>
        /// Gets the position.
        /// </summary>
        public Point2d Position { get; }

        /// <summary>
        /// Gets the direction.
        /// </summary>
        public Direction Direction{ get; }

        /// <summary>
        /// Gets the length.
        /// </summary>
        public double Length{ get; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        public double Width{ get; }

        /// <summary>
        /// Create a new Transform with the given values.
        /// </summary>
        /// <param name="position">start position</param>
        /// <param name="direction">start direction</param>
        /// <param name="length">the object length</param>
        /// <param name="width">the object width</param>
        public Transform(Point2d position, Direction direction, double length, double width) {
            Position = position;
            Direction = direction;
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Gets the upper left position of the object.
        /// </summary>
        /// <returns>the upper left position</returns>
        public Point2d UpperLeftPosition() => new Point2d(Position.X - Length / 2, Position.Y - Width / 2);

    }
    
}