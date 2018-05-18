using System.Diagnostics.Contracts;

namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            switch (item)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                case "veggie":
                    return new ChicagoStyleVeggiePizza();
            }
            return null;
        }
    }
}