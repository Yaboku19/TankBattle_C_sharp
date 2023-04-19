namespace TankBattle.GameObject
{
    /// <summary>
    /// Represents the factory that creates all the different GameObject
    /// </summary>
    public interface IGameOjectFactory
    {
        /// <summary>
        /// Create a new tank, recognizable by the component Tank.
        /// </summary>
        /// <param name="pos">Start position</param>
        /// <param name="player">Player associated to the tank</param>
        /// <returns>a new tank</returns>
        IGameObject CreateSimpleTank(Point2d pos, Player player);

        /// <summary>
        /// Create a new bullet.
        /// </summary>
        /// <param name="tank">tank that shoot the bullet</param>
        /// <returns>the new bullet</returns>
        IGameObject CreateSimpleBullet(IGameObject tank);

        /// <summary>
        /// Create a new wall.
        /// </summary>
        /// <param name="pos">wall position</param>
        /// <returns>a new wall</returns>
        IGameObject CreateSimpleWall(Point2d pos);
    }
}
