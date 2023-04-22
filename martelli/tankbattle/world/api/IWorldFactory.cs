namespace world.api
{
    using data;
    public interface IWorldFactory
    {
        IWorld CreateWorld(int player1, int player2, MapData mapdata);
    }
}
