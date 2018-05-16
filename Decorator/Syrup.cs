namespace Decorator
{
    public class Syrup : CondimentDecorator
    {
        private Beverage beverage;

        public Syrup(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public new string GetDescription()
        {
            return string.Join(", ", beverage.GetDescription(), "Syrup");
        }

        public override double Cost()
        {
            return 0.5 + beverage.Cost();
        }
    }
}