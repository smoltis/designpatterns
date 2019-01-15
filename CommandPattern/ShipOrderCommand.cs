namespace CommandPattern
{
    internal class ShipOrderCommand : ICommandFactory, ICommand
    {
        public string CommandName => "ShipOrder";

        public string Description => "Will mark the order ready for shipping";

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