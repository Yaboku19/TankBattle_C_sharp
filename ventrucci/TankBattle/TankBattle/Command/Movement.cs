using ClassiFittizie;
using HumanPlayer;

namespace Command
{
    public class Movement : ICommand
    {
        private readonly Direction _dir;
        private readonly IPlayer _player;

        public Movement(Direction dir, IPlayer player)
        {
            _dir = dir;
            _player = player;
        }

        public void Execute(CommandListener model)
        {
            model.SetDirection(_dir, _player);
        }
    }
}