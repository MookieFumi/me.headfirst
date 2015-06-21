namespace me.headfirst.Command.Second
{
    public interface IMeCommand
    {
        void Execute();
    }

    public class FirstRemoteControl
    {
        private IMeCommand _command;

        public void SetCommand(IMeCommand command)
        {
            _command = command;
        }

        public void ButtonWasPressed()
        {
            _command.Execute();
        }
    }

    public class OpenDoorCommand : IMeCommand
    {
        private readonly Door _door;

        public OpenDoorCommand(Door door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Open();
        }
    }

    public class Door
    {
        public void Open()
        {
            
        }

        public void Close()
        {
            
        }
    }
}
