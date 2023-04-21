namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents an abstraction over the behaviour attachable to a GameObject.
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Gets the GameObject attached to this Component.
        /// </summary>
        /// <returns> the attached GameObject</returns>
        IGameObject GameObject { get; }

        /// <summary>
        /// Specifies the GameObject to which this Component gets attached.
        /// </summary>
        /// <param name="gameObject"> the given GameObject</param>
        void AttachGameObject(IGameObject gameObject);
    }
}
