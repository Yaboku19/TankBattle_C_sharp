using ClassiFittizie;
using Command;
using InputController;
using Player;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace TankBattleTest
{
    [TestClass]
    public class CommandTest
    {
        private static readonly IPlayer _player = new HumanPlayer("test", new TankData());
        private readonly IInputController<int> _inputController = new KeyboardInputController<int>(1, 2, 3, 4, 5, _player);


        [TestMethod]
        public void TestStartCommand()
        {
            ICommand? moveUp = _inputController.StartCommand(1);
            Assert.IsNotNull(moveUp);
            Assert.AreEqual(typeof(Movement), moveUp.GetType());
            Assert.IsNull(_inputController.StartCommand(1));
            Assert.IsNull(_inputController.StartCommand(7));
            ICommand? shoot = _inputController.StartCommand(5);
            Assert.IsNotNull(shoot);
            Assert.AreEqual(typeof(Shoot),shoot.GetType());
        }

        [TestMethod]
        public void TestStopCommand()
        {
            _inputController.StartCommand(1);
            Assert.IsNull(_inputController.StopCommand(2));
            ICommand? moveUp = _inputController.StopCommand(1);
            Assert.IsNotNull(moveUp);
            Assert.AreEqual(typeof(Movement), moveUp.GetType());
            Assert.IsNull(_inputController.StopCommand(7));
            _inputController.StartCommand(5);
            ICommand? shoot = _inputController.StopCommand(5);
            Assert.IsNull(shoot);
        }

    }
}
