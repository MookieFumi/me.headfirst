namespace me.headfirst.Factory.First.Pizzas
{
    class BarcelonaCheesePizza : Pizza
    {
        public BarcelonaCheesePizza()
        {
            base.name = "BarcelonaCheesePizza";
            base.dough = "Thin Crust Dough";
            base.sauce = "Marinara Sauce";

            base._toppings.Add("Grated Reggiano Cheese");
        }
    }
}