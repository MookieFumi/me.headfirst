using System;
using System.Collections.Generic;

namespace me.headfirst.Command.Second
{
    public class CommandFactory2
    {
        private readonly IDictionary<string, Lazy<CommandWithUndo>> _commands;

        public CommandFactory2()
        {
            _commands = new Dictionary<string, Lazy<CommandWithUndo>>();
        }

        public void Register(string commandName, Lazy<CommandWithUndo> lazyCommand)
        {
            _commands.Add(commandName, lazyCommand);
        }

        public void Register(string commandName, Action execute, Action undo)
        {
            _commands.Add(commandName, new Lazy<CommandWithUndo>(() => new CommandWithUndo(execute, undo)));
        }

        private CommandWithUndo GetCommand(string commandName)
        {
            return _commands[commandName].Value;
        }

        public void Execute(string commandName)
        {
            GetCommand(commandName).Execute();
        }

        public void Undo(string commandName)
        {
            GetCommand(commandName).Undo();
        }
    }
}