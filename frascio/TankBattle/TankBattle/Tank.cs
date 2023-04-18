namespace TankBattle
{
    public class Tank : AbstractComponent
    {
        private double _timer;
        private readonly double _shotCountdown;
        private const double StandardCountdown = 1000;
        private const double StandardSpeed = 0.1;
        private const double SpeedReducer = 100;
        private const int StandardDamage = 50;

        public Tank(Player player)
        {
            this.Player = player;
            this.Speed = StandardSpeed;
            this.Damage = StandardDamage;
            this._shotCountdown = StandardCountdown + 100 / Speed;
            this._timer = this._shotCountdown;
        }

        public int Damage { get; }
        
        public double Speed { get; }
        
        public Player Player { get;}
        
        public override void Update(double time)
        {
            this._timer = this._timer + time; 
        }

        public bool CanShoot() {
            if(this._timer >= _shotCountdown) {
                this._timer = 0;
                return true;
            }
            return false;
        }
        
        
    }
}