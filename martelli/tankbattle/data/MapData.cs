namespace data
{
    using gameobjectimportedbyfrascio;
    public class MapData
    {
        private List<Point2d> _wall;
        private Point2d _firstTankPosition;
        private Point2d _secondTankPosition;

        public MapData(IEnumerable<Point2d> wallPosition, Point2d firstTankPosition, Point2d secondTankPosition)
        {
            _wall = wallPosition.ToList();
            _firstTankPosition = firstTankPosition;
            _secondTankPosition = secondTankPosition;
        }

        public IEnumerable<Point2d> Wall => _wall;

        public Point2d FirstTankPosition => _firstTankPosition;

        public Point2d SecondTankPosition => _secondTankPosition;
    }
}
