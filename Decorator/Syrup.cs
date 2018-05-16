namespace Decorator
{
    public class Syrup : CondimentDecorator //concrete decorator
    {

        public Syrup(Beverage beverage) : base(beverage)
        {

        }
        public override string GetDescription()
        {
            return string.Join(", ", beverage.GetDescription(), "Syrup");
        }

        public override double Cost()
        {
            return 0.5 + beverage.Cost();
        }
    }
}