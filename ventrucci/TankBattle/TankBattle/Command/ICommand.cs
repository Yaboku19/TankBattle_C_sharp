using ClassiFittizie;
namespace Command
{
    /// <summary>
    /// This interface represent a Command that come from player.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute the command.
        /// </summary>
        /// <param name="model">Sodel command listener.</param>
        void Execute(CommandListener model);
    }
    
}