namespace Decorator
{
    public class FlatWhite : Beverage //concrete component
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