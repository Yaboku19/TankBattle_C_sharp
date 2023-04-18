namespace TankBattle
{
    public class Tank : AbstractComponent
    {
        private double _timer = 0;
        private readonly double _shotCountdown;
        private const double StandardCountdown = 1000;
        private const double StandardSpeed = 0.1;
        private const double SpeedReducer = 100;

        public Tank(Player player)
        {
            this.Player = player;
            //Speed
            //Damage
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