namespace me.headfirst.Observer.Framework
{
    public class WeatherInfo
    {
        public WeatherInfo(float temperature, float humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
        }

        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}