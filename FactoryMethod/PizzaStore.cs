using System;
namespace FactoryMethod
{
    public abstract class PizzaStore
    {

        public abstract Pizza CreatePizza(string item);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            Console.WriteLine($"--- Making {pizza.GetName()} ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
