using System;

namespace me.headfirst.Decorator.First.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return String.Format("{0}, {1}", _beverage.GetDescription(), "Soy");
        }

        public override double Cost()
        {
            return _beverage.Cost() + 15;
        }
    }
}