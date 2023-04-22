namespace TankBattle.Rettori.Main
{
    public interface IObservableCollidable : IComponent
    {
        void AddListener(CollisionListener listener);

        void RemoveListener(CollisionListener listener);
    }
}
