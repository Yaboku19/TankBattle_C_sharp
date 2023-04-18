namespace TankBattle
{
    public interface IComponent
    {
        void Update(double time);

        IGameObject GameObject {get; set; }
    }
}