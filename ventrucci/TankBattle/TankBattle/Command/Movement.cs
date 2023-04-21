using ClassiFittizie;
using Player;
using System.Numerics;

namespace Command
{
    /// <summary>
    /// That class manage movement Command of the player.
    /// </summary>
    public class Movement : ICommand
    {
        private readonly Direction _dir;
        private readonly IPlayer _player;

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="dir">New direction to set</param>
        /// <param name="player">Player to set new direction</param>

        public Movement(Direction dir, IPlayer player)
        {
            _dir = dir;
            _player = player;
        }

        /// <inheritdoc />
        public void Execute(CommandListener model)
        {
            model.SetDirection(_dir, _player);
        }
    }
}