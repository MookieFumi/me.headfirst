using System;
using me.headfirst.Strategy.Behaviors;

namespace me.headfirst.Strategy
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior= new QuackMute();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}