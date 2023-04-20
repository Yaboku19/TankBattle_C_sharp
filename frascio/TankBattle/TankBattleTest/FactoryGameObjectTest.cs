namespace TankBattleTest
{
    [TestClass]
    public class FactoryGameObjectTest
    {
        #pragma warning disable CS8618
        private IGameOjectFactory _gameOjectFactory;

        [TestInitialize]
        public void Init()
        {
            _gameOjectFactory = new GameObjectFactory();
        }

        [TestMethod]
        public void TestTankCreation()
        {
            IGameObject tank = _gameOjectFactory.CreateSimpleTank(new Point2d(10, 10), new Player());
            Assert.IsFalse(tank.GetComponent<Tank>() == null);
            Assert.AreEqual(tank.Transform.Position.X, 10);
            Assert.AreEqual(tank.Transform.Position.Y, 10);
        }

        [TestMethod]
        public void TestBulletCreation()
        {
            IGameObject tank = _gameOjectFactory.CreateSimpleTank(new Point2d(10, 10), new Player());
            IGameObject bullet = _gameOjectFactory.CreateSimpleBullet(tank);
            Assert.IsFalse(bullet.GetComponent<Bullet>() == null);
        }

        [TestMethod]
        public void TestWallCreation()
        {
            IGameObject wall = _gameOjectFactory.CreateSimpleWall(new Point2d(100, 100));
            Assert.IsFalse(wall.GetComponent<Wall>() == null);
        }
    }
}
