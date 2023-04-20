using ClassiFittizie;
using System;

namespace Player
{
    /// <summary>
    /// 
    /// </summary>
    public class HumanPlayer : IPlayer
    {

        private int _score;
        private readonly String _name;
        private readonly TankData _tankData;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tankData"></param>
        public HumanPlayer( String name, TankData tankData)
        {
            _score = 0;
            _name = name;
            _tankData = tankData;
        }
        /// <summary>
        /// 
        /// </summary>
        public int GetScore => _score;
        /// <summary>
        /// 
        /// </summary>
        public string GetName => _name;
        /// <summary>
        /// 
        /// </summary>
        public TankData GetTankData => _tankData;
        /// <summary>
        /// 
        /// </summary>
        public void IncScore()
        {
            _score ++;
        }
    }
}