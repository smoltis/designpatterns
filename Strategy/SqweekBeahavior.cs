using System;

namespace Strategy
{
    public class SqweekBeahavior : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("SQUEEK!!!");
        }
    }
}