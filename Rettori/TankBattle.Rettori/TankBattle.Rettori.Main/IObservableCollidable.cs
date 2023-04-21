namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents a way to register CollisionListeners to be notified when collisions happen.
    /// </summary>
    public interface IObservableCollidable : IComponent
    {
        /// <summary>
        /// Adds a CollisionListener.
        /// </summary>
        /// <param name="listener"> the CollisionListener to be added</param>
        void AddListener(CollisionListener listener);

        /// <summary>
        /// Removes a CollisionListener.
        /// </summary>
        /// <param name="listener"> the CollisionListener to be removed</param>
        void RemoveListener(CollisionListener listener);
    }
}
