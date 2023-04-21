using Command;
using System.Collections.Generic;

namespace InputController
{
    /// <summary>
    /// This interface represent an InputController that gets notified when an input occours.
    /// </summary>
    /// <typeparam name="T">KeyCode type</typeparam>
    public interface IInputController<T>
    {
        /// <summary>
        /// Returns a List with keys of the controller.
        /// </summary>
        /// <returns>List of keys</returns>
        List<T> GetKeys();

        /// <summary>
        /// Start command.
        /// </summary>
        /// <param name="command">Command to start</param>
        /// <returns>Nullable of the new command created</returns>
        ICommand? StartCommand(T? command);

        /// <summary>
        /// Stop command.
        /// </summary>
        /// <param name="command">Command to stop</param>
        /// <returns>Nullable of the new command created</returns>
        ICommand? StopCommand(T? command);
    }
}