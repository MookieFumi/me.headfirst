using me.headfirst.Factory.First.Pizzas;

namespace me.headfirst.Factory.First.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType type);
    }
}