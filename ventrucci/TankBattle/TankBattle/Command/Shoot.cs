using HumanPlayer;
using ClassiFittizie;

namespace Command
{
    public class Shoot : ICommand
    {
        private readonly IPlayer _player;

        public Shoot(IPlayer player)
        {
            _player = player;
        }

        public void Execute(CommandListener model)
        {
            model.Shoot(_player);
        }
    }
}