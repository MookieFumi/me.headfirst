using System;

namespace me.headfirst.Strategy.Behaviors
{
    public class QuackSqueak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak sound");
        }
    }
}