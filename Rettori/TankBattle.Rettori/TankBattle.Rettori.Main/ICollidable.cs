namespace TankBattle.Rettori.Main
{
    public interface ICollidable : IComponent
    {
        void ResolveCollision(IGameObject collidingObject);
    }
}
