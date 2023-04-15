namespace Command
{
    public class Shoot : ICommand
    {
        private readonly Player _player;

        public Shoot(readonly Player player)
        {
            _player = player;
        }

        public void Execute(readonly CommandListener model)
        {
            model.Shoot(_player);
        }
    }
}