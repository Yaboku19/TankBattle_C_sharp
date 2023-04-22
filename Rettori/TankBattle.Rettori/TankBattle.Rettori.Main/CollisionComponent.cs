namespace TankBattle.Rettori.Main
{
    public class CollisionComponent : ICollidable, IObservableCollidable
    {
        private readonly IList<CollisionListener> _listeners = new List<CollisionListener>();

        public IGameObject GameObject { get; private set; }

        public void AttachGameObject(IGameObject gameObject)
        {
            GameObject = gameObject;
        }

        public void AddListener(CollisionListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(CollisionListener listener)
        {
            _listeners.Remove(listener);
        }

        public void ResolveCollision(IGameObject collidingObject)
        {
            foreach (CollisionListener listener in _listeners)
            {
                listener(GameObject, collidingObject);
            }
        }
    }
}
