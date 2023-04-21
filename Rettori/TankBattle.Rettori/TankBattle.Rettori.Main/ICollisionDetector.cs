namespace TankBattle.Rettori.Main
{
    public interface ICollisionDetector
    {
        bool Detect(Transform object1, Transform object2);
    }
}
