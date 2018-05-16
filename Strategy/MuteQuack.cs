using System;

namespace Strategy
{
    internal class MuteQuack : IQuackBehavior
    {
        public void PerformQuack()
        {
            Console.WriteLine("...(silence)...");
        }
    }
}