namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents an implementation of the Collidable Component.
    /// </summary>
    public class CollisionComponent : ICollidable, IObservableCollidable
    {
        private readonly IList<CollisionListener> _listeners = new List<CollisionListener>();

        public IGameObject GameObject { get; private set; }

        /// <summary>
        /// Specifies the GameObject to which this Component gets attached.
        /// </summary>
        /// <param name="gameObject"> the given GameObject</param>
        public void AttachGameObject(IGameObject gameObject)
        {
            GameObject = gameObject;
        }

        /// <inheritdoc />
        public void AddListener(CollisionListener listener)
        {
            _listeners.Add(listener);
        }

        /// <inheritdoc />
        public void RemoveListener(CollisionListener listener)
        {
            _listeners.Remove(listener);
        }

        /// <inheritdoc />
        public void ResolveCollision(IGameObject collidingObject)
        {
            foreach (CollisionListener listener in _listeners)
            {
                listener(GameObject, collidingObject);
            }
        }
    }
}
