using Player;
using ClassiFittizie;

namespace Command
{
    /// <summary>
    /// That class manage shoot Command of the player.
    /// </summary>
    public class Shoot : ICommand
    {
        private readonly IPlayer _player;

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="player">Player want to shoot</param>
        public Shoot(IPlayer player)
        {
            _player = player;
        }
        
        /// <inheritdoc />
        public void Execute(CommandListener model)
        {
            model.Shoot(_player);
        }
    }
}