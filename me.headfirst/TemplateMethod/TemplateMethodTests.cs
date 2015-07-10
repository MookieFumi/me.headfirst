using System;
using me.headfirst.TemplateMethod.First;
using NUnit.Framework;

namespace me.headfirst.TemplateMethod
{
    public class TemplateMethodTests
    {
        [Test]
        public void BeverageTest()
        {
            Console.WriteLine("Making cofee");
            var coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine("Making tea");
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("Making cofee");
            var coffeeWithHook = new Coffee.CoffeeWithHook(false);
            coffeeWithHook.PrepareRecipe();
        }
    }
}
