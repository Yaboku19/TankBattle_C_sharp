using Command;
using Player;
using System.Collections;
using System.Collections.Generic;

namespace InputController
{
    public class KeyboardInputController<T> : IInputController<T>
    {
        private readonly T _moveUp;
        private readonly T _moveDown;
        private readonly T _moveLeft;
        private readonly T _moveRight;
        private readonly T _shoot;
        private readonly IPlayer _player;
        private T? _lastCommand;

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

        public List<T> getKeys()
        {
            return new List<T>{_moveUp, _moveDown, _moveLeft, _moveRight, _shoot};
        }

        public ICommand? StartCommand(T? command)
        {
            if (command != null && _lastCommand != null) {
                ICommand ret;
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

        public ICommand? StopCommand(T? command)
        {
            if (!_lastCommand.Equals(command) || command.Equals(_shoot)) {
                return null;
            }
            _lastCommand = default(T);
            ICommand? ret = new Movement(Direction.NONE, _player);
            return ret;
        }

    }

}