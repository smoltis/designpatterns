using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The Strategy Pattern
             *
             * Defines a family of algorithms, encapsulates each one, and makes them interchangable.
             * Strategy lets the algorithm vary dependently from clients that use it.
             *
             * Solves problems:
             * -behaviors defined at compilation not runtime
             * -decereased code flexibility
             * -duplicate the code
             *
             * Allows:
             * -interchangeable algorithms for behavior for each object
             * -change behaviors at runtime
             * -common behaviors code can be reused as behaviours can be shared
             * -Favor composition over inheritance. (Design Principle #3)
             * -Program to an interface not implementation. (Design Principle #2)
             * -Identify the aspect of your code that vary and separate them from what stays the same.[Encapsulate What Varies] (Design Principle #1)
             *
             */

            //This is a Duck simulator of different kinds of ducks

            var mallard = new MallardDuck(); //can swim, quack, fly

            mallard.Display();
            mallard.Swim();
            mallard.Fly();
            mallard.Quack();

            Console.WriteLine();

            var redhead = new RedheadDuck(); //can swim, quack, fly

            redhead.Display();
            redhead.Swim();
            redhead.Fly();
            redhead.Quack();

            Console.WriteLine();

            var decoy = new DecoyDuck(); //can swim only

            decoy.Display();
            decoy.Swim();
            decoy.Fly();
            decoy.Quack();

            Console.WriteLine();

            var rubber = new RubberDuck(); //can swim and squeek, can't fly

            rubber.Display();
            rubber.Swim();
            rubber.Fly();
            rubber.Quack();

            Console.WriteLine();

            var model = new ModelDuck(); //can swim, can fake quack, can't fly unless defined

            model.Display();
            model.Swim();
            model.Fly();
            model.SetFlyBehavoir(new FlyRocketPowered());
            model.Fly();
            model.Quack();

            Console.ReadLine();

        }
    }

}
