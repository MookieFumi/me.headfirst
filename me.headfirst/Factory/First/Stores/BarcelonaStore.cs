using me.headfirst.Factory.First.Pizzas;

namespace me.headfirst.Factory.First.Stores
{
    public class BarcelonaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case PizzaType.Cheese:
                    pizza = new BarcelonaCheesePizza();
                    break;
            }

            return pizza;
        }
    }
}