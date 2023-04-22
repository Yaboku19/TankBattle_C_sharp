using gameobjectimportedbyfrascio;

namespace world.api
{
    public interface IWorld
    {
        IEnumerable<IGameObject> Entities {get; }

        void RemoveGameObject(IGameObject gameObject);

        void AddGameObject(IGameObject gameObject);
    }
}
