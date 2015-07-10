using System;

namespace me.headfirst.TemplateMethod.First
{
    public abstract class BeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        protected abstract void AddCondiments();

        protected abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
    }
}