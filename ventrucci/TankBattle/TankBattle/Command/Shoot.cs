using Player;
using ClassiFittizie;

namespace Command
{   /// <summary>
    /// 
    /// </summary>
    public class Shoot : ICommand
    {
        private readonly IPlayer _player;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        public Shoot(IPlayer player)
        {
            _player = player;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Execute(CommandListener model)
        {
            model.Shoot(_player);
        }
    }
}