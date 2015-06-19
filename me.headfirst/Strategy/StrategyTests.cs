using System;
using me.headfirst.Strategy.Behaviors;
using NUnit.Framework;

namespace me.headfirst.Strategy
{
    public class StrategyTests
    {
        [Test]
        public void DuckTest()
        {
            var mallardDuck = new MallardDuck();
            CallMethods(mallardDuck);

            var rubberDuck = new RubberDuck();
            CallMethods(rubberDuck);

            var redheadDuck = new RedheadDuck();
            CallMethods(redheadDuck);
            redheadDuck.SetFlyBehavior(new FlyRocketPowered());
            CallMethods(redheadDuck);
        }

        private void CallMethods(Duck duck)
        {
            Console.WriteLine(duck.GetType().Name);
            duck.PerfomFly();
            duck.PerformQuack();
            Console.WriteLine("------------");
        }
    }
}
