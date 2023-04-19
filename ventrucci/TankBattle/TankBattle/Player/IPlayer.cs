using ClassiFittizie;
using System;

namespace HumanPlayer
{
    public interface IPlayer
    {
        
        int getScore{ get; }

        void incScore();

        String getName{ get; }

        TankData getTankData{ get; }
    }
}