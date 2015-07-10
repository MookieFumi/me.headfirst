namespace me.headfirst.Facade.Seoncd
{
    class Station
    {
        private readonly Thermometer _thermometer;

        public Station(Thermometer thermometer)
        {
            _thermometer = thermometer;
        }

        public float GetTemperature()
        {
            return _thermometer.GetTemperature();
        }

        public Thermometer GetThermomiter()
        {
            return _thermometer;
        }
    }
}