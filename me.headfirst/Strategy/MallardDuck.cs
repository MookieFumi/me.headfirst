using System;
using me.headfirst.Strategy.Behaviors;

namespace me.headfirst.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new QuackSqueak();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}