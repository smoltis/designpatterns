namespace Decorator
{
    public class SoyMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SoyMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public new string GetDescription()
        {
            return string.Join(", ", _beverage.GetDescription(), "Soy Milk");
        }

        public override double Cost()
        {
            return 0.5 + _beverage.Cost();
        }
    }
}