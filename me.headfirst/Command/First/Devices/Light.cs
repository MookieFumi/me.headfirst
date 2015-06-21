using System;

namespace me.headfirst.Command.First.Devices
{
    public class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} - {1}", _location, "On");
        }

        public void Off()
        {
            Console.WriteLine("{0} - {1}", _location, "Off");
        }
    }
}