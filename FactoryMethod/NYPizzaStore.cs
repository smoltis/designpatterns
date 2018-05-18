namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            switch (item)
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
            }
            return null;
        }
    }
}