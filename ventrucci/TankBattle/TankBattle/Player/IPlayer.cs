using ClassiFittizie;
using System;

namespace Player
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// 
        /// </summary>
        int GetScore{ get; }
        /// <summary>
        /// 
        /// </summary>
        void IncScore();
        /// <summary>
        /// 
        /// </summary>
        String GetName{ get; }
        /// <summary>
        /// 
        /// </summary>
        TankData GetTankData{ get; }
    }
}