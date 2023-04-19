using TankBattle.GameObject;

namespace TankBattle.Component
{
    /// <summary>
    /// Implements the common behaviours for every Component.
    /// </summary>
    public abstract class AbstractComponent : IComponent
    {
        /// <inheritdoc />
        public abstract void Update(double time);

        /// <inheritdoc />
#pragma warning disable CS8618
        public IGameObject GameObject { get; set; }

    }
}