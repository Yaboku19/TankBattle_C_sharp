
using System.Collections.Generic;
using System.Linq;

namespace TankBattle
{
    public class GameObject : IGameObject
    {
        private List<IComponent> _components;
        private Transform _transform;

        public GameObject(Transform transform)
        {
            _transform = transform;
            _components = new List<IComponent>();
        }

        public List<IComponent> Components  => new List<IComponent>(_components);

        public Transform Transform => new Transform(_transform.Position, _transform.Direction, _transform.Length, _transform.Width);

        public Point2d Position { set => _transform = new Transform(value, _transform.Direction, _transform.Length, _transform.Width); }

        public void Update(double time) => _components.ForEach(component => component.Update(time));

        public Direction Direction 
        { 
            set 
            {
                if(value != Direction.NONE)
                    _transform = new Transform(_transform.Position, value, _transform.Length, _transform.Width);
                //if(getComponent(movableComponent) !=null )
            }
        }

        public T? GetComponent<T>() where T : IComponent
        {
            return _components.OfType<T>().FirstOrDefault(); //optional
        }

        public IGameObject AddComponent(IComponent component)
        {
            this.Components.Add(component);
            component.GameObject = this;
            return this;
        }
    }
}