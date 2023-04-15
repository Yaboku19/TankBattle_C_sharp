using Command;
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
        private readonly Player _player;
        private Nullable<T> lastCommand = null;

        public KeyboardInputController(T moveUp, T moveDown, T moveLeft,
            T moveRight, T shoot, Player player)
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
            return new List.List(_moveUp, _moveDown, _moveLeft, _moveRight, _shoot);
        }

        public ICommand? StartCommand(T ICommand)
        {
            if (!lastCommand.equals(Optional.of(command))) {
                if (command.equals(_shoot)) {
                    return Optional.of(new Shoot(_player));
                }
                lastCommand = Optional.of(command);
                if (command.equals(_moveRight)) {
                    return Optional.of(new Movement(Direction.RIGHT, _player));
                }
                if (command.equals(_moveLeft)) {
                    return Optional.of(new Movement(Direction.LEFT, _player));
                }
                if (command.equals(_moveUp)) {
                    return Optional.of(new Movement(Direction.UP, _player));
                }
                if (command.equals(_moveDown)) {
                    return Optional.of(new Movement(Direction.DOWN, _player));
                }
            }
            return Optional.empty();
        }

        public ICommand? StopCommand(T ICommand)
        {
            if (!lastCommand.equals(Optional.of(command)) || command.equals(_shoot)) {
                return Optional.empty();
            }
            lastCommand = Optional.empty();
            return Optional.of(new Movement(Direction.NONE, _player));
        }

    }
}