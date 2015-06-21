using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace me.headfirst.Command.First
{
    public class RemoteControl
    {
        private readonly IList<ICommand> _onCommands;
        private readonly IList<ICommand> _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new Collection<ICommand>();
            _offCommands = new Collection<ICommand>();

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands.Add(noCommand);
                _offCommands.Add(noCommand);
            }

            _undoCommand = new NoCommand();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }
    }
}