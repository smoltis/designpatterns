namespace Decorator
{
    public class Capuccino : Beverage
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