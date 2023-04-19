using TankBattle.Component;

namespace TankBattle.GameObject
{
    /// <summary>
    /// Basic implementation of the interface IGameObject.
    /// </summary>
    public class GameObject : IGameObject
    {
        private List<IComponent> _components;
        private Transform _transform;

        /// <summary>
        /// Constructor of all the GameObject.
        /// </summary>
        /// <param name="transform">Transform associated to this GameObject</param>
        public GameObject(Transform transform)
        {
            _transform = transform;
            _components = new List<IComponent>();
        }

        /// <inheritdoc />
        public List<IComponent> Components => new List<IComponent>(_components);

        /// <inheritdoc />
        public Transform Transform => new Transform(_transform.Position, _transform.Direction, _transform.Length, _transform.Width);

        /// <inheritdoc />
        public Point2d Position { set => _transform = new Transform(value, _transform.Direction, _transform.Length, _transform.Width); }

        /// <inheritdoc />
        public void Update(double time) => _components.ForEach(component => component.Update(time));

        /// <inheritdoc />
        public Direction Direction
        {
            set
            {
                if (value != Direction.NONE)
                    _transform = new Transform(_transform.Position, value, _transform.Length, _transform.Width);
            }
        }

        /// <inheritdoc />
        public T? GetComponent<T>() where T : IComponent
        {
            return _components.OfType<T>().FirstOrDefault();
        }

        /// <inheritdoc />
        public IGameObject AddComponent(IComponent component)
        {
            _components.Add(component);
            component.GameObject = this;
            return this;
        }
    }
}