namespace Database_Factory.Commands.Command_Controller
{
    public interface ICommandsController
    {
        bool Check();

        void Execute();
    }
}