namespace SimpleFactory
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "Clam Pizza";
            dough = "Crust";
            sauce = "Marinara Sauce";
            toppings.Add("Seafood");
        }
    }
}