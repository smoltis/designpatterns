using System;

namespace CommandPattern
{
    // Command line order management system
    // Editing command will invoke command pattern
    public class Program
    {
        static void Main(string[] args)
        {
            Program1.Run(args); // w/o Command Pattern
            Program2.Run(args); // w/ Command Pattern
        }
    }
}
