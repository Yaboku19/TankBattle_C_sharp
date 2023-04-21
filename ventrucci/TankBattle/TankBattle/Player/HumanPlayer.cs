using ClassiFittizie;
using System;

namespace Player
{
    /// <summary>
    /// An implementation of Player.
    /// </summary>
    public class HumanPlayer : IPlayer
    {

        private int _score;
        private readonly String _name;
        private readonly TankData _tankData;

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="tankData">Tank data</param>
        public HumanPlayer( String name, TankData tankData)
        {
            _score = 0;
            _name = name;
            _tankData = tankData;
        }

        /// <inheritdoc/>
        public int GetScore => _score;

        ///  <inheritdoc/>
        public string GetName => _name;

        
        /// <inheritdoc/>
        public TankData GetTankData => _tankData;


        /// <inheritdoc/>
        public void IncScore()
        {
            _score ++;
        }
    }
}