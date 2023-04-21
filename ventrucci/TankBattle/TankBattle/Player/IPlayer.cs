using ClassiFittizie;
using System;

namespace Player
{
    /// <summary>
    /// Represents the player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Get the player's score.
        /// </summary>
        int GetScore{ get; }

        /// <summary>
        /// Increase score.
        /// </summary>
        void IncScore();

        /// <summary>
        /// Get the player's name.
        /// </summary>
        String GetName{ get; }

        /// <summary>
        /// Get Tank Data.
        /// </summary>
        TankData GetTankData{ get; }
    }
}