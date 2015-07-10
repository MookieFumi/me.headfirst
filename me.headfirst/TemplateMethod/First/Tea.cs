using System;

namespace me.headfirst.TemplateMethod.First
{
    public class Tea : Beverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}