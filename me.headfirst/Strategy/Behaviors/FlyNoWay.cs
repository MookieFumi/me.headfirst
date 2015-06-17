using System;

namespace me.headfirst.Strategy.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No fly");
        }
    }
}