using System;

namespace me.headfirst.Facade.First
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly CdPlayer _cdPlayer;
        private readonly DvdPlayer _dvdPlayer;
        private readonly Projector _projector;
        private readonly Tuner _tuner;

        public HomeTheaterFacade(
            Amplifier amplifier, 
            Tuner tuner, 
            DvdPlayer dvdPlayer, 
            CdPlayer cdPlayer,
            Projector projector)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDVD(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down");
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}