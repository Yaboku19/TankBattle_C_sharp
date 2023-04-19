using ClassiFittizie;
using HumanPlayer;

namespace Command
{
    public class Movement : ICommand
    {
        private readonly Direction _dir;
        private readonly IPlayer _player;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="player"></param>
        public Movement(Direction dir, IPlayer player)
        {
            _dir = dir;
            _player = player;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Execute(CommandListener model)
        {
            model.SetDirection(_dir, _player);
        }
    }
}