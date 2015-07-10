using System;

namespace me.headfirst.TemplateMethod.First
{
    public class Coffee: Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        public class CoffeeWithHook : BeverageWithHook
        {
            private readonly bool _withCondiments;

            public CoffeeWithHook(bool withCondiments)
            {
                _withCondiments = withCondiments;
            }

            public override bool CustomerWantsCondiments()
            {
                return _withCondiments;
            }

            protected override void AddCondiments()
            {
                Console.WriteLine("Adding sugar and milk");
            }

            protected override void Brew()
            {
                Console.WriteLine("Dripping coffee through filter");
            }
        }

    }
}