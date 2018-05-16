namespace Decorator
{
    public class Espresso : Beverage //concrete component
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 3.0;
        }
    }
}