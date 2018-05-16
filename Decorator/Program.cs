using System;

namespace Decorator
{
    class Program
    {
        /*
         * The Decorator Pattern
         *
         * attached additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
         *
         * Example:
         * Coffe Shop
         *  3 types of coffee with price: Espresso $2.5, Mocha $3, Capuccino $3, etc.
         *  Each of which can have extras/condiments: Soy $1, Whip $0.5, Double $1.5, Decaf $1, etc.
         *
         *  Problem:
         *  1. Class Chaos: Abstract Beverage class -> Coffee subclasses, override cost() -> more sub-classes for options
         *  2. Boolean properties on Beverage class -> Set options on each coffee instance -> calculate cost in the instance. Inflexible design, price change is problematic.
         *
         * Calsses should be open for extension but closed for modification. [Open-Closed Principle] (Design Principle #5)
         * Easily augment what we have.
         *
         * Solution:
         * Every new extra will encapsulate already existing i.e.  new Double(new Whip(new Mocha())) so that every new option has its cost() method.
         *
         */

        static void Main(string[] args)
        {
            //plain Espresso
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            //Fancy Flat White
            Beverage beverage1 = new FlatWhite();
            beverage1 = new SoyMilk(beverage1);
            beverage1 = new Syrup(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()}  ${beverage1.Cost()}");

            //Iced Espresso
            Beverage beverage2 = new Espresso();
            beverage2 = new Ice(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

            Console.ReadLine();
        }
    }
}
