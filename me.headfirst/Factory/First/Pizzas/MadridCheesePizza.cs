using System;

namespace me.headfirst.Factory.First.Pizzas
{
    class MadridCheesePizza : Pizza
    {
        public MadridCheesePizza()
        {
            base.name = "MadridCheesePizza";
            base.dough = "Extra Thick Crust Dough";
            base.sauce = "Plum Tomato Sauce";

            base._toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}