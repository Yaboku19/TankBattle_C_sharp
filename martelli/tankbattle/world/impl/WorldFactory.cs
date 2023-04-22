namespace world.impl
{
    using data;
    using world.api;
    using gameobjectimportedbyfrascio;
    public class WorldFactory : IWorldFactory
    {
        private readonly int _size = 10;

        public IWorld CreateWorld(int player1, int player2, MapData mapdata)
        {
            HashSet<GameObject> entities = new HashSet<GameObject>();
            entities.UnionWith(GetWalls(mapdata));
            entities.Add(CreateGameObject(mapdata.FirstTankPosition, player1));
            entities.Add(CreateGameObject(mapdata.SecondTankPosition, player2));
            return new World(entities);
        }

        private IEnumerable<GameObject> GetWalls(MapData mapdata) =>
            mapdata.Wall.Select(w => CreateWallObject(Position(w)));
        
        private GameObject CreateWallObject(Point2d position) =>
            new GameObject(new Transform(position, Direction.UP, _size, _size));
        
        private GameObject CreateGameObject(Point2d position, int player) =>
            new GameObject(new Transform(position, Direction.UP, _size, _size));

        private Point2d Position(Point2d position) =>
            new Point2d(position.X * _size + _size / 2, position.Y * _size + _size / 2);
        
    }
}
