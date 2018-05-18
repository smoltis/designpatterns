namespace SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            name = "Veggie Pizza";
            dough = "Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Shredded Mozarella");
            toppings.Add("Grated parmesan");
            toppings.Add("Diced onion");
            toppings.Add("Sliced mushrooms");
            toppings.Add("Sliced capsicum");
            toppings.Add("Sliced black olives");
        }
    }
}