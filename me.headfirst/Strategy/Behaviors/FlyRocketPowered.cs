using System;

namespace me.headfirst.Strategy.Behaviors
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly like a rocket");
        }
    }
}