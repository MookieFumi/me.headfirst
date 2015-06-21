using System;

namespace me.headfirst.Command.First.Devices
{
    public class Stereo
    {
        private readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void SetCD()
        {
        }

        public void SetVolume(int i)
        {
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