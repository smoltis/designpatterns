namespace Decorator
{
    public abstract class CondimentDecorator : Beverage //decorator
    {
        protected Beverage beverage;
        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }
}