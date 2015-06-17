using System;

namespace me.headfirst.Strategy.Behaviors
{
    public class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm mute");
        }
    }
}