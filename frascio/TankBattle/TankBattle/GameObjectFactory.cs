namespace TankBattle
{
    /// <summary>
    /// Basic implementation of IGameObjectFactory.
    /// </summary>
    public class GameObjectFactory : IGameOjectFactory
    {
        private static readonly double SimpleTankDimension = 50;
        private static readonly double SimpleBulletDimension = 10;
        private static readonly double SimpleWallDimension = 40;

        /// <inheritdoc />
        public IGameObject CreateSimpleTank(Point2d pos, Player player) =>
            new GameObject(new Transform(pos, Direction.UP, SimpleTankDimension, SimpleTankDimension))
                .AddComponent(new Tank(player));

        /// <inheritdoc />
        public IGameObject CreateSimpleBullet(IGameObject tank) =>
            new GameObject(new Transform(BulletPosition(tank), tank.Transform.Direction,
                SimpleBulletDimension, SimpleBulletDimension));

        /// <inheritdoc />
        public IGameObject CreateSimpleWall(Point2d pos) =>
            new GameObject(new Transform(pos, Direction.NONE, SimpleWallDimension, SimpleWallDimension));

        private Point2d BulletPosition(IGameObject tank) =>
            new Point2d(tank.Transform.Position.X +
                tank.Transform.Direction.X * (tank.Transform.Length / 2 + SimpleBulletDimension),
                tank.Transform.Position.Y +
                tank.Transform.Direction.X * (tank.Transform.Length / 2 + SimpleBulletDimension));
    }
}
