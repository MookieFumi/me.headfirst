using me.headfirst.Facade.First;
using me.headfirst.Facade.Seoncd;
using NUnit.Framework;

namespace me.headfirst.Facade
{
    public class FacadeTests
    {
        [Test]
        public void HomeTheaterFacadeTest()
        {
            var homeTheater = new HomeTheaterFacade(new Amplifier(), new Tuner(), new DvdPlayer(), new CdPlayer(), new Projector());
            homeTheater.WatchMovie("Lost");
            homeTheater.EndMovie();
        }
    }
}
