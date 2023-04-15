namespace Command
{
    public class Moovement : ICommand
    {
        private readonly Direction _dir;
        private readonly Player _player;

        public Moovement(readonly Direction dir, readonly Player player)
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