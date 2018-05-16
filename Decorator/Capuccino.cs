namespace Decorator
{
    public class Capuccino : Beverage //concrete component
    {
        public Capuccino()
        {
            Description = "Capuccino";
        }
        public override double Cost()
        {
            return 3.5;
        }
    }
}