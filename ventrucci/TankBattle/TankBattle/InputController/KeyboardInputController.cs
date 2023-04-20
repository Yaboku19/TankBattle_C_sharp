using Command;
using ClassiFittizie;
using System.Collections;
using System.Collections.Generic;
using Player;

namespace InputController
{   /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class KeyboardInputController<T> : IInputController<T>
    {
        private readonly T _moveUp;
        private readonly T _moveDown;
        private readonly T _moveLeft;
        private readonly T _moveRight;
        private readonly T _shoot;
        private readonly IPlayer _player;
        private T? _lastCommand;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moveUp"></param>
        /// <param name="moveDown"></param>
        /// <param name="moveLeft"></param>
        /// <param name="moveRight"></param>
        /// <param name="shoot"></param>
        /// <param name="player"></param>
        public KeyboardInputController(T moveUp, T moveDown, T moveLeft,
            T moveRight, T shoot, IPlayer player)
            {
                    _moveUp = moveUp;
                    _moveDown = moveDown;
                    _moveLeft = moveLeft;
                    _moveRight = moveRight;
                    _shoot = shoot;
                    _player = player;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T> GetKeys()
        {
            return new List<T>{_moveUp, _moveDown, _moveLeft, _moveRight, _shoot};
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public ICommand? StartCommand(T? command)
        {
            if (command != null && _lastCommand != null) {
                ICommand? ret;
                if (!_lastCommand.Equals(command)) {
                    if (command.Equals(_shoot)) {
                        ret = new Shoot(_player);
                        return ret;
                    }
                    _lastCommand = command;
                    if (command.Equals(_moveRight)) {
                        ret = new Movement(Direction.RIGHT, _player);
                        return ret;
                    }
                    if (command.Equals(_moveLeft)) {
                        ret = new Movement(Direction.LEFT, _player);
                        return ret;
                    }
                    if (command.Equals(_moveUp)) {
                        ret = new Movement(Direction.UP, _player);
                        return ret;
                    }
                    if (command.Equals(_moveDown)) {
                        ret = new Movement(Direction.DOWN, _player);
                        return ret;
                    }
                }
                return null;
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public ICommand? StopCommand(T? command)
        {
            if (_lastCommand != null && !_lastCommand.Equals(command) || command != null && command.Equals(_shoot)) {
                return null;
            }
            _lastCommand = default(T);
            ICommand? ret = new Movement(Direction.NONE, _player);
            return ret;
        }

    }

}