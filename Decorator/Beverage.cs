namespace Decorator
{
    public abstract class Beverage //component
    {
        protected string Description = "Unknown beverage";

        public abstract double Cost();

        public virtual string GetDescription()
        {
            return Description;
        }
    }
}