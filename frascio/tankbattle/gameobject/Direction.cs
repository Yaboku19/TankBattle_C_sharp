namespace gameobject
{
    public sealed class Direction
    {
        public double X {get; }
        public double Y {get; }

        public Point2d Vector => new Point2d(this.X, this.Y);


        public static readonly Direction UP = new Direction(0, 1);
        public static readonly Direction DOWN = new Direction(0, -1);
        public static readonly Direction LEFT = new Direction(-1, 0);
        public static readonly Direction RIGTH = new Direction(1, 0);
        public static readonly Direction NONE = new Direction(0, 0);

        public Direction(double X, int y)
        {
            this.X = X;
            this.Y = y;
        }
    }
}