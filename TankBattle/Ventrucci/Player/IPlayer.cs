namespace Player
{
    public interface Player
    {
        
        int getScore{ get; }

        void incScore();

        String getName{ get; }

        TankData getTankData{ get; }
    }
}