using System;
namespace SimpleFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            factory = pizzaFactory;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            pizza = factory.CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
