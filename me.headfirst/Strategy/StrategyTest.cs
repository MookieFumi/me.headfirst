using System;
using NUnit.Framework;

namespace me.headfirst.Strategy
{
    public class StrategyTest
    {
        [Test]
        public void DuckTest()
        {
            var mallardDuck = new MallardDuck();
            CallMethods(mallardDuck);

            var rubberDuck = new RubberDuck();
            CallMethods(rubberDuck);
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
