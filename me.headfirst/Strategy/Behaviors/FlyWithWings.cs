using System;

namespace me.headfirst.Strategy.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I believe I can fly");
        }
    }
}