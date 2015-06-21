using System;

namespace me.headfirst.Command.First
{
    public class SimpleRemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }
    }
}