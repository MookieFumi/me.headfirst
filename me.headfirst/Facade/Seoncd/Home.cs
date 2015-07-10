namespace me.headfirst.Facade.Seoncd
{
    //Talk only to your immediate friends
    class Home
    {
        private readonly Station _station;

        public Home(Station station)
        {
            _station = station;
        }

        public float GetTempWithoutPrinciple()
        {
            Thermometer thermometer = _station.GetThermomiter();
            return thermometer.GetTemperature();
        }

        public float GetTemp()
        {
            return _station.GetTemperature();
        }
    }
}
