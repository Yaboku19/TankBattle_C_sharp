using System.Security.Cryptography.X509Certificates;
using TankBattle.Rettori.Main;
using Xunit.Sdk;

namespace TankBattle.Rettori.Test
{
    public class CollisionComponentTest
    {
        private readonly IGameObject _self;
        private readonly CollisionComponent _component;
        private readonly IGameObject _other;
        private bool _called;

        public CollisionComponentTest()
        {
            _self = new TestGameObject();
            _component = new CollisionComponent();
            _component.AttachGameObject(_self);
            _other = new TestGameObject();

        }

        public class TestGameObject : IGameObject
        {
            public Transform Transform { get; } = new Transform();

            public T GetComponent<T>() where T : IComponent
            {
                return default;
            }
        }


        [Fact]
        public void TestAddListener()
        {
            _component.AddListener((s, o) =>
            {
                _called = true;
            });
            _component.ResolveCollision(_other);
            Assert.True(_called);
        }

        [Fact] 
        public void TestListenerArguments()
        {
            _component.AddListener((s, o) => {
                Assert.Equal(_self, s);
                Assert.Equal(_other, o);
            });
            _component.ResolveCollision(_other);
        }

        [Fact]
        public void TestRemoveListener()
        {
            CollisionListener listener = (s, o) => throw new XunitException("Test failed");
            _component.AddListener(listener);
            _component.RemoveListener(listener);
            _component.ResolveCollision(_other);
        }

        [Fact]
        public void TestNoListeners()
        {
            _component.ResolveCollision(_other);
        }

        [Fact]
        public void TestMoreListeners()
        {
            _component.AddListener((s, o) =>
            {
                Assert.Equal(_self, s);
                Assert.Equal(_other, o);
            });
            _component.AddListener((s, o) =>
            {
                Assert.Equal(_self, s);
                Assert.Equal(_other, o);
            });
            _component.ResolveCollision(_other);
        }
    }
}
