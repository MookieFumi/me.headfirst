using me.headfirst.Factory.First.Pizzas;

namespace me.headfirst.Factory.First.Stores
{
    public class MadridStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new MadridCheesePizza();
                    break;
            }

            return pizza;
        }
    }
}