using Command;

namespace InputController
{
    public interface IInputController<T>
    {
        List<T> getKeys();

        Nullable<ICommand> StartCommand(T command);

        Nullable<ICommand> StopCommand(T command);
    }
}