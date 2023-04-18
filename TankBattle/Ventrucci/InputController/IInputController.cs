using Command;

namespace InputController
{
    public interface IInputController<T>
    {
        List<T> getKeys();

        ICommand? StartCommand(T? command);

        ICommand? StopCommand(T? command);
    }
}