using System;

namespace me.headfirst.Decorator.First.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), "Whip");
        }

        public override double Cost()
        {
            return _beverage.Cost() + 10;
        }
    }
}