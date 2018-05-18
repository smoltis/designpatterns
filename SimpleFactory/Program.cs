using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzaOrder = new List<Pizza>();
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaOrder.Add(pizzaStore.OrderPizza("cheese"));
            pizzaOrder.Add(pizzaStore.OrderPizza("veggie"));

            foreach (var item in pizzaOrder)
            {
                Console.WriteLine($"We ordered a {item.GetName()}");
                Console.WriteLine(item);
            }
        }


    }
}
