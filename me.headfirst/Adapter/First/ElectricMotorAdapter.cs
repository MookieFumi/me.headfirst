namespace me.headfirst.Adapter.First
{
    public class ElectricMotorAdapter : ICombustionEngine
    {
        private readonly ElectricMotor _electricMotor;

        public ElectricMotorAdapter()
        {
            _electricMotor = new ElectricMotor();
        }

        public void SpeeUp()
        {
            _electricMotor.MoveIt();
        }

        public void TurnOn()
        {
            _electricMotor.Connect();
            _electricMotor.Activate();
        }

        public void TurnOff()
        {
            _electricMotor.Stop();
            _electricMotor.Disconnect();
        }
    }
}