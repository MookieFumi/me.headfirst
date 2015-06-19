using me.headfirst.Factory.First;
using me.headfirst.Factory.First.Stores;
using NUnit.Framework;

namespace me.headfirst.Factory
{
    public class FactoryTests
    {
        [Test]
        public void PizzaShopTest()
        {
            var madridStore = new MadridStore();
            var pizza = madridStore.OrderPizza(PizzaType.Cheese);

            var barcenlonaStore = new BarcelonaStore();
            var pizza2 = barcenlonaStore.OrderPizza(PizzaType.Cheese);
        }
    }
}
