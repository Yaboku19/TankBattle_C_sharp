using TankBattle;

namespace TankBattleTest
{
    [TestClass]
    public class GameObjectTest
    {
        
        private static IGameObject BasicGameObject() => new GameObject
            (new Transform(new Point2d(10, 10), Direction.UP, 20, 20))
            .AddComponent(new Tank(new Player()));

        [TestMethod]
        public void TestDirection()
        {
            IGameObject _tank = BasicGameObject();
            _tank.Direction = Direction.DOWN;
            Assert.AreEqual(Direction.DOWN, _tank.Transform.Direction);
        }

    }
}
