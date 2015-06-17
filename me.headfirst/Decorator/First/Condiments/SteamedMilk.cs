using System;

namespace me.headfirst.Decorator.First.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), "SteamedMilk");
        }

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}