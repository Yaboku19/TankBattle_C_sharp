namespace TankBattle.Rettori.Main
{
    public interface IGameObject
    {
        T GetComponent<T>() where T : IComponent;

        Transform Transform { get; }
    }
}
