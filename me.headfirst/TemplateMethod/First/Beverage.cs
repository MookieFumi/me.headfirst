using System;

namespace me.headfirst.TemplateMethod.First
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
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
