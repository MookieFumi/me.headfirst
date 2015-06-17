using System;

namespace me.headfirst.Decorator.First.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), "Mocha");
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}