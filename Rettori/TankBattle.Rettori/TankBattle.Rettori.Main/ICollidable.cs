namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents a particular Component that enables the attached GameObject to collide.
    /// </summary>
    public interface ICollidable : IComponent
    {
        /// <summary>
        /// Handles the collision with the given GameObject.
        /// </summary>
        /// <param name="collidingObject"> the colliding object</param>
        void ResolveCollision(IGameObject collidingObject);
    }
}
