using System;
using System.IO;
using me.headfirst.Decorator.First;
using me.headfirst.Decorator.First.Beverages;
using me.headfirst.Decorator.First.Condiments;
using me.headfirst.Decorator.Second;
using me.headfirst.Decorator.Second.Components;
using me.headfirst.Decorator.Second.Phones;
using me.headfirst.Strategy;
using me.headfirst.Strategy.Behaviors;
using NUnit.Framework;

namespace me.headfirst.Decorator
{
    public class DecoratorTest
    {
        [Test]
        public void BeverageTest()
        {
            Beverage expresso = new Expresso();
            Console.WriteLine("{0}, {1}€", expresso.GetDescription(), expresso.Cost());

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            houseBlend = new SteamedMilk(houseBlend);
            houseBlend = new Soy(houseBlend);

            Console.WriteLine("{0}, {1}€", houseBlend.GetDescription(), houseBlend.Cost());
        }

        [Test]
        public void PhoneTest()
        {
            Phone nexus = new Nexus6();
            nexus = new FrontCamera13MP(nexus);
            nexus = new MemoryCard64GB(nexus);
            DisplayPhoneInfo(nexus);

            Phone edge = new S6Edge();
            edge = new FrontCamera6MP(edge);
            edge = new MemoryCard64GB(edge);
            DisplayPhoneInfo(edge);
        }

        private void DisplayPhoneInfo(Phone phone)
        {
            Console.WriteLine("Specs: {0}. Final prices: {1}€", phone.GetSpecifications(), phone.Cost());
        }
    }
}
