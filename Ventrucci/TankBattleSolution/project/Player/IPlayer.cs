using System;

namespace Player
{
    public interface IPlayer
    {
        
        int getScore{ get; }

        void incScore();

        String getName{ get; }

        TankData getTankData{ get; }
    }
}