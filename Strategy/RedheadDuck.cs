using System;

namespace Strategy
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck!");
        }
    }
}