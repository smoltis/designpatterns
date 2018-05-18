namespace SimpleFactory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
			name = "Pepperoni Pizza";
			dough = "Thin Crust";
			sauce = "Marinara Sauce";
            toppings.Add("Pepperoni");
        }
    }
}