using System;

namespace CommandPattern
{
    public static class Program1
    {
        public static void Run(string[] args)
        {
           if (args.Length == 0)
           {
               PrintUsage();
               return;
           } 
           var porocessor = new CommandExecutor();
           porocessor.ExecuteCommand(args);
        }

        private static void PrintUsage()
        {
            System.Console.WriteLine(" Usage: LoggingDemo CommandName Arguments");
            System.Console.WriteLine("Commands:");
            System.Console.WriteLine("  UpdateQuantity number");
            System.Console.WriteLine("  CreateOrder");
            System.Console.WriteLine("  ShipOrder");
        }
    }
}