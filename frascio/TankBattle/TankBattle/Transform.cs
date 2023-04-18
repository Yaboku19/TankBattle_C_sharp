namespace TankBattle
{
    public class Transform
    {
        public Point2d Position { get; }
        public Direction Direction{ get; }
        public double Length{ get; }
        public double Width{ get; }

        public Transform(Point2d position, Direction direction, double length, double width) {
            Position = position;
            Direction = direction;
            Length = length;
            Width = width;
        }
    }
    
}