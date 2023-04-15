namespace Command
{
    public class Shoot : ICommand
    {
        private readonly Player _player;

        public Shoot(Player player)
        {
            _player = player;
        }

        public void Execute(CommandListener model)
        {
            model.Shoot(_player);
        }
    }
}