namespace CommandPattern
{
    public class UpdateQuantityCommand : ICommandFactory, ICommand
    {
        public int NewQuantity {get; set; }

        public string CommandName => "UpdateQuantity";

        public string Description => "Update the quantity for the order";

        public void Execute()
        {
            const int oldQuantity = 5;
            //simulate database update
            System.Console.WriteLine("DATABASE: Updated");
            // simulate logging
            System.Console.WriteLine("LOG: Updated Qty from {0} to {1}", oldQuantity, NewQuantity);
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new UpdateQuantityCommand {NewQuantity = int.Parse(arguments[1])};
        }
    }
}