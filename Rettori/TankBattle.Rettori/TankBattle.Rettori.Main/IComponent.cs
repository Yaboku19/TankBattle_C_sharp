namespace TankBattle.Rettori.Main
{
    public interface IComponent
    {
        IGameObject GameObject { get; }

        void AttachGameObject(IGameObject gameObject);
    }
}
