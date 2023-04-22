namespace gamestate.api
{
    using data;
    using gameobjectimportedbyfrascio;
    public interface IGameState : CommandListener
    {
        void CreateWorld(MapData mapData, int player1, int player2);

        void Update(double time);

        IEnumerable<Transform> BulletsTrasform {get; }

        IEnumerable<Transform> WallsTrasform {get; }

        Transform? GetTankTrasform(int player);

        int GetTankLife(int player);
    }
}
