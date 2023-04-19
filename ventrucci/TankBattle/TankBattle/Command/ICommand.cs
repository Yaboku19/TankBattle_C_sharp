using ClassiFittizie;
namespace Command
{
    public interface ICommand
    {
        void Execute(CommandListener model);
    }
    
}