namespace TankBattleTest
{
    [TestClass]
    public class GameObjectTest
    {
        #pragma warning disable CS8618
        private IGameObject _tank;

        [TestInitialize]
        public void Init() 
        {
            _tank = new GameObject(new Transform(new Point2d(10, 10), Direction.UP, 20, 20))
                .AddComponent(new Tank(new Player()));
        }

        [TestMethod]
        public void TestDirection()
        {
            _tank.Direction = Direction.DOWN;
            Assert.AreEqual(Direction.DOWN, _tank.Transform.Direction);
        }

        [TestMethod]
        public void TestPosition()
        {
            Assert.AreEqual(_tank.Transform.Position.X, 10);
            Assert.AreEqual(_tank.Transform.Position.Y, 10);
            _tank.Position = new Point2d(20, 20);
            Assert.AreEqual(_tank.Transform.Position.X, 20);
            Assert.AreEqual(_tank.Transform.Position.Y, 20);
            Assert.AreEqual(_tank.Transform.UpperLeftPosition().Y, 10);
            Assert.AreEqual(_tank.Transform.UpperLeftPosition().X, 10);
        }

        [TestMethod]
        public void TestGetComponent()
        {
            var tankComponent = _tank.GetComponent<Tank>();
            Assert.AreEqual(_tank.Components.Count, 1);
            Assert.IsTrue(tankComponent != null);
            Assert.IsTrue(tankComponent is Tank);
        }

        #pragma warning disable CS8602
        [TestMethod]
        public void TestUpdate()
        {
            Assert.IsTrue(_tank.GetComponent<Tank>().CanShoot());
            Assert.IsFalse(_tank.GetComponent<Tank>().CanShoot());
            _tank.Update(2000);
            Assert.IsTrue(_tank.GetComponent<Tank>().CanShoot());

        }


    }
}
