namespace Decorator
{
    public class SoyMilk : CondimentDecorator //concrete decorator
    {

        public SoyMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return string.Join(", ", beverage.GetDescription(), "Soy Milk");
        }

        public override double Cost()
        {
            return 0.5 + beverage.Cost();
        }
    }
}