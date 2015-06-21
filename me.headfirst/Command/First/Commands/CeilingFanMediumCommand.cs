using me.headfirst.Command.First.Devices;

namespace me.headfirst.Command.First.Commands
{
    public class CeilingFanMediumCommand : ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _previousSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Medium();
        }

        public void Undo()
        {
            if (_previousSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_previousSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_previousSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            }
            else if (_previousSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}