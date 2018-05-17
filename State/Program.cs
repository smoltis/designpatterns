using System;

namespace State
{
    class Program
    {
        /*
         * The State Pattern
         * 
         * allows an object to alter its behavior when its internal state changes. The object will apprear ti change its class.
         * 
         * Exmaple:
         * We have gumball machine (Context) that can have different states (State) i.e. HasQuarter, NoQuarter, SoldOut, Sold
         * each state corresponds a behavior method i.e. InsertQuarter(), EjectQuarter(), TurnCrank(), Dispence() (ConcreteState)
         *
         * 
         * Implementation:
         * We'll define a interface with behavior methods and implement it for each state. 
         * The pattern encapsulates states in to separate classes.
         * So that each state is represented by own class.
         * Context deligates requests to the current state.
         * Once the request is handled the state may change.
         * We encapsulate what varies.
         * Favor composition over inheritance.
         * We keep the calsses closed for modification but open for extension.
         * 
         * 
         * 
         */

        static void Main(string[] args)
        {

            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
            Console.ReadLine();
        }
    }
}
