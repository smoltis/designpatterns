using System;
namespace Decorator
{
    public class Ice : CondimentDecorator
    {

        public Ice(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return 0.5 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return string.Join(", ", beverage.GetDescription(), "Iced");
        }
    }
}
