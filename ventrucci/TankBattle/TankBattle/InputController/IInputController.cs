using Command;
using System.Collections.Generic;

namespace InputController
{   /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IInputController<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<T> GetKeys();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        ICommand? StartCommand(T? command);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        ICommand? StopCommand(T? command);
    }
}