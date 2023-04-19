using TankBattle.GameObject;

namespace TankBattle.Component
{
    /// <summary>
    /// Represents an abstraction over the behaviour attachable to a GameObject.
    /// </summary>
    public interface IComponent
    {
        /// <summary>
        /// Given an elapsed time, updates the behaviour of the GameObject.
        /// </summary>
        /// <param name="time">time elapsed</param>
        void Update(double time);

        /// <summary>
        /// Property to get and set the GameObject attached to this component.
        /// </summary>
        IGameObject GameObject { get; set; }
    }
}