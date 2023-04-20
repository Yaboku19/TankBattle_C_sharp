using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle.Rettori.Main
{
    public class CollisionManagerImpl
    {
        private readonly ICollisionDetector _detector;

        public CollisionManagerImpl(ICollisionDetector detector)
        {
            _detector = detector;
        }

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
                    pair.Item2.GameObject.Transform)
                );
        }
    }
}
