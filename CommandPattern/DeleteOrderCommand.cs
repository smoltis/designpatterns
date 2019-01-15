namespace CommandPattern
{
    internal class DeleteOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => "DeleteOrder";

        public string Description => "Will delete the order from the system";

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