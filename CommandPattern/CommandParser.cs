using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandPattern
{
    public class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            this.availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];
            var command = FindRequestedCommand(requestedCommandName);
            if (null == command)
                {
                    return new NotFoundCommand {Name = requestedCommandName};
                }
            return command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string commandName)
        {
            return availableCommands
                    .FirstOrDefault( cmd => cmd.CommandName == commandName);
        }
    }
}