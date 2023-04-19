using System;

namespace HumanPlayer
{
    public class HumanPlayer : IPlayer
    {

        private int _score;
        private readonly String _name;
        private readonly TankData _tankData;

        public HumanPlayer( String name, TankData tankData)
        {
            _score = 0;
            _name = name;
            _tankData = tankData;
        }

        public int getScore => _score;

        public string getName => _name;

        public TankData getTankData => _tankData;

        public void incScore()
        {
            _score ++;
        }
    }
}