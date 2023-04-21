namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents a strategy to manage the colliding objects.
    /// </summary>
    public class CollisionManagerImpl
    {
        private readonly ICollisionDetector _detector;

        public CollisionManagerImpl(ICollisionDetector detector)
        {
            _detector = detector;
        }

        /// <summary>
        /// Checks all the objects in an Enumerable and calls the ResolveCollision
        /// method on the ones who are colliding.
        /// </summary>
        /// <param name="objects"> Enumerable of all the colliding objects</param>
        public void ManageCollisions(IEnumerable<IGameObject> objects)
        {
            IEnumerable<(ICollidable, ICollidable)> collidingObjects = FindCollidingObjects(
                objects
                    .Select(x => x.GetComponent<ICollidable>())
                    .Where(x => x != null)
            );
            collidingObjects
                .ToList()
                .ForEach(pair =>
                {
                    pair.Item1.ResolveCollision(pair.Item2.GameObject);
                    pair.Item2.ResolveCollision(pair.Item1.GameObject);
                });
        }

        private IEnumerable<(ICollidable, ICollidable)> FindCollidingObjects(IEnumerable<ICollidable> collidables)
        {
            IList<ICollidable> collidablesList = collidables.ToList();
            return Enumerable
                .Range(0, collidablesList.Count)
                .SelectMany(index => collidablesList
                    .Skip(index + 1)
                    .Select(x => (collidablesList[index], x)))
                .Where(pair => _detector.Detect(
                    pair.Item1.GameObject.Transform,
                    pair.Item2.GameObject.Transform));
        }
    }
}
