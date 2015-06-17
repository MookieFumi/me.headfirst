using System;
using me.headfirst.Strategy.Behaviors;

namespace me.headfirst.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new QuackMute();
            FlyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}