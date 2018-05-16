namespace Decorator
{
    public abstract class Beverage
    {
        public string Description = "Unknown beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}