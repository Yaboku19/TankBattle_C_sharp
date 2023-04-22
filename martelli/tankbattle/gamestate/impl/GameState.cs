namespace gamestate.impl
{
    using System.Collections.Generic;
    using gameobjectimportedbyfrascio;
    using gamestate.api;
    using world.api;
    using world.impl;
    public class GameState : IGameState
    {
        private IWorld? _world = null;

        public GameState()
        {

        }

        public IEnumerable<Transform> BulletsTrasform=>
            GetObjByComponent<IComponent>().Select(g => g.Transform); // instead of IComponent it is needed Bullet

        public IEnumerable<Transform> WallsTrasform =>
            GetObjByComponent<IComponent>().Select(g => g.Transform); // instead of IComponent it is needed Wall

        public void CreateWorld()
        {
            _world = new World(new List<GameObject>());
        }

        public int GetTankLife(int player)
        {
            throw new NotImplementedException();
        }

        public Transform? GetTankTrasform(int player) =>
            GetObjByComponent<IComponent>()/*.Where(g => g.Player == player)*/.Select(g => g.Transform).FirstOrDefault();

        public void Update(double time)
        {
            if (_world is not null)
            {
                _world.Entities.ToList().ForEach(g => g.Update(time));
                _world.Entities.Where(this.IsDead).ToList().ForEach(this.RemoveDeadObject);
                // collision
            } else
            {
                throw new NotImplementedException();
            }
        }

        private bool IsDead(IGameObject gameObject) =>
            GetObjByComponent<IComponent>().Contains(gameObject) // It is needed Healt class
                ? false // !gameObject.GetComponent<IComponent>().IsAlive()
                : false;
        
        private void RemoveDeadObject(IGameObject gameObject) {
            if (GetObjByComponent<IComponent>().Contains(gameObject)) // it is needed Tank
            {
                // endGame
            } else if (_world is not null)
            {
                _world.RemoveGameObject(gameObject);
            } else
            {
                throw new NotImplementedException();
            }
        }

        private  IEnumerable<IGameObject> GetObjByComponent<T>() where T : IComponent =>
            _world is not null
                ? _world.Entities.Where(g => g.GetComponent<T>() is not null)
                : new List<IGameObject>();

        public void Shoot(int player) =>
            GetObjByComponent<IComponent>()/*.Where(g => g.Player = player).FirstOrDefault().Shoot()*/;

        public void Movement(int player, Direction direction) =>
            GetObjByComponent<IComponent>()/*.Where(g => g.Player = player).FirstOrDefault().Movement(direction)*/;
    }
}