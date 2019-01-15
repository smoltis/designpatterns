using System;

namespace CommandPattern
{
    public class CommandExecutor
    {
        public CommandExecutor()
        {
        }
        internal void ExecuteCommand(string[] args)
        {
            switch (args[0])
            {
                case "UpdateQuantity":
                    UpdateQuantity(int.Parse(args[1]));
                    break;
                case "CreateOrder":
                    CreateOrder();
                    break;
                case "ShipOrder":
                    ShipOrder();
                    break;
                default:
                    System.Console.WriteLine("unrecognised command");
                    break;
            }
        }

        private void ShipOrder()
        {
            throw new NotImplementedException();
        }

        private void CreateOrder()
        {
            throw new NotImplementedException();
        }

        private void UpdateQuantity(int newQuantity)
        {
            // simulate database update
            const int oldQuantity = 5;
            System.Console.WriteLine("DATABASE: Updated");

            //simulate logging
            System.Console.WriteLine("LOG: Updated order quantity from {0} to {1}", oldQuantity, newQuantity);
        }
    }
}