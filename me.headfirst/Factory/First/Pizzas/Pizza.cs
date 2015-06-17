using System;
using System.Collections.ObjectModel;

namespace me.headfirst.Factory.First.Pizzas
{
    public abstract class Pizza
    {
        protected String name;
        protected string dough;
        protected string sauce;
        protected readonly Collection<String>  _toppings = new Collection<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing pizza {0}", name);
            Console.WriteLine("Toosing dough {0}", dough);
            Console.WriteLine("Adding sauce {0}", sauce);
            foreach (var topping in _toppings)
            {
                Console.WriteLine("Adding topping {0}", topping);
            }
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in box");
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutesa at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza (Default style)");
        }
    }
}
