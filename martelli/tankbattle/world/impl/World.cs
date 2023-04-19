namespace world.impl
{
    using gameobjectimportedbyfrascio;
    using world.api;
    public class World : IWorld
    {
        private readonly List<IGameObject> _entities;

        public World(IEnumerable<IGameObject> _entities) => this._entities = _entities.ToList();

        public IEnumerable<IGameObject> Entities => _entities;

        public void AddGameObject(IGameObject gameObject) => _entities.Add(gameObject);

        public void RemoveGameObject(IGameObject gameObject) => _entities.Remove(gameObject);
    }
}