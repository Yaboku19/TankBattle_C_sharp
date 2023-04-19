namespace TankBattle.Component
{
    /// <summary>
    /// Represents a particular Component that marks the attached.
    /// GameObject as a Tank
    /// </summary>
    public class Tank : AbstractComponent
    {
        private double _timer;
        private readonly double _shotCountdown;
        private const double StandardCountdown = 1000;
        private const double StandardSpeed = 0.1;
        private const double SpeedReducer = 100;
        private const int StandardDamage = 50;

        /// <summary>
        /// Initializes a new Tank given its associated Player.
        /// </summary>
        /// <param name="player">the Player associated to the Tank</param>
        public Tank(Player player)
        {
            Player = player;
            Speed = StandardSpeed;
            Damage = StandardDamage;
            _shotCountdown = StandardCountdown + 100 / Speed;
            _timer = _shotCountdown;
        }

        /// <summary>
        /// Gets the tank damage.
        /// </summary>
        public int Damage { get; }

        /// <summary>
        /// Gets the tank speed.
        /// </summary>
        public double Speed { get; }

        /// <summary>
        /// Gets the tank associated Player.
        /// </summary>
        public Player Player { get; }

        /// <inheritdoc />
        public override void Update(double time)
        {
            _timer = _timer + time;
        }

        /// <summary>
        /// Returns whether this Tank can shoot.
        /// </summary>
        /// <returns>true if can shoot, false otherwise</returns>
        public bool CanShoot()
        {
            if (_timer >= _shotCountdown)
            {
                _timer = 0;
                return true;
            }
            return false;
        }


    }
}