using System;
using System.Collections.Generic;

namespace CommandPattern
{
    internal class Program2
    {
        internal static void Run(string[] args)
        {
            System.Console.WriteLine("#####With CommandPattern#####");
            var availableCommands = GetAvailbleCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }
            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);
            command.Execute();

        }

        private static IEnumerable<ICommandFactory> GetAvailbleCommands()
        {
            return new ICommandFactory[]
            {
                new CreateOrderCommand(),
                new UpdateQuantityCommand(),
                new ShipOrderCommand(),
                new DeleteOrderCommand() //added by putting it on this list and creating a new class
            };
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            System.Console.WriteLine(" Usage: LoggingDemo CommandName Arguments");
            System.Console.WriteLine("Commands:");
            foreach(var cmd in availableCommands)
            {
                System.Console.WriteLine("  {0}", cmd.CommandName);
            }
        }
    }
}