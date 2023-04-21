namespace TankBattle.Rettori.Main
{
    /// <summary>
    /// Represents a standard GameObject.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Gets the specified Component, if present.
        /// </summary>
        /// <param name="T"> any type of behaviour extending Component</param>
        /// <returns> the Component</returns>
        T GetComponent<T>() where T : IComponent;

        /// <summary>
        /// Gets the Transform associated to this GameObject.
        /// </summary>
        /// <returns> the associated Transform</returns>
        Transform Transform { get; }
    }
}
