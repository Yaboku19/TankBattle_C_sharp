namespace gamestate.api
{
    using gameobjectimportedbyfrascio;
    public interface CommandListener
    {
        void Shoot(int player);

        void Movement(int player, Direction direction); 
    }
}
