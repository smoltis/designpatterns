namespace Decorator
{
    public class FlatWhite : Beverage
    {
        public FlatWhite()
        {
            Description = "Flat White";
        }
        public override double Cost()
        {
            return 3.5;
        }
    }
}