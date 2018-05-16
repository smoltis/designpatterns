using System;

namespace Strategy
{
    public class Quack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("QUACK!!!");
        }
    }
}