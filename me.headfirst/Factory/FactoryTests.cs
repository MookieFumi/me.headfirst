using me.headfirst.Factory.First;
using me.headfirst.Factory.First.Stores;
using me.headfirst.Factory.Second;
using me.headfirst.Factory.Second.Shops;
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

        [Test]
        public void CanyonShopTest()
        {
            var onlineShop = new OnlineShop();
            var nerve = onlineShop.OrderNerve(FrameSize.TwentyNine);

            var retailShop = new RetailShop();
            var nerve2 = retailShop.OrderNerve(FrameSize.Default);
        }
    }
}
