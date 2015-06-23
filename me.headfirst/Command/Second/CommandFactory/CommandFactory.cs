using System;
using System.Collections.Generic;
using System.Linq;

namespace me.headfirst.Command.Second.CommandFactory
{
    public class CommandFactory
    {
        private readonly IDictionary<string, Action> _commands;

        public CommandFactory()
        {
            _commands = new Dictionary<string, Action>();
        }

        public void Register(string commandName, Action action)
        {
            _commands.Add(commandName, action);
        }

        private Action GetCommand(string commandName)
        {
            return _commands.Single(p => p.Key == commandName).Value;
        }

        public void Execute(string commandName)
        {
            GetCommand(commandName)();
        }
    }
}