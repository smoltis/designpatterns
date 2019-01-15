namespace CommandPattern
{
    public class CreateOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => "CreateOrder";

        public string Description => "Will create a new order";

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public ICommand MakeCommand(string[] arguments)
        {
            throw new System.NotImplementedException();
        }
    }
}