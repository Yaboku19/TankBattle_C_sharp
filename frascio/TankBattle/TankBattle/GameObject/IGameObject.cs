using System.Collections.Generic;
using TankBattle.Component;

namespace TankBattle.GameObject
{
    /// <summary>
    /// Represents the interface for all the GameObject in the game.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Getter property for all the components attached to the GameObject.
        /// </summary>
        List<IComponent> Components { get; }

        /// <summary>
        /// Getter property for the Transform.
        /// </summary>
        Transform Transform { get; }

        /// <summary>
        /// Sets the Direction.
        /// </summary>
        Direction Direction { set; }

        /// <summary>
        /// Sets the position of the GameObject.
        /// </summary>
        Point2d Position { set; }

        /// <summary>
        /// Update all the components attached to this GameObject.
        /// </summary>
        /// <param name="time">Time elapsed after last update</param>
        void Update(double time);

        /// <summary>
        /// Add the component passed to the GameObject.
        /// </summary>
        /// <param name="component">Component that have to be attached to this GameObject</param>
        /// <returns>this</returns>
        IGameObject AddComponent(IComponent component);

        /// <summary>
        /// Gets the specified component, if present.
        /// </summary>
        /// <typeparam name="T">any type of behaviour extending Component</typeparam>
        /// <returns>The component, null if not present</returns>
        T? GetComponent<T>() where T : IComponent;

    }

}