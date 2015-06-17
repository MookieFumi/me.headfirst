using me.headfirst.Strategy.Behaviors;

namespace me.headfirst.Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public void Swim()
        {
        }

        public void PerfomFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public abstract void Display();


    }
}