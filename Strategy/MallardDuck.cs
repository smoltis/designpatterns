using System;

namespace Strategy
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mullard Duck!");
        }
    }
}