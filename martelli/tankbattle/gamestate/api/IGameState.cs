namespace gamestate.api
{
    using gameobjectimportedbyfrascio;
    public interface IGameState : CommandListener
    {
        void CreateWorld();

        void Update(double time);

        IEnumerable<Transform> BulletsTrasform {get; }

        IEnumerable<Transform> WallsTrasform {get; }

        Transform? GetTankTrasform(int player);

        int GetTankLife(int player);
    }
}
