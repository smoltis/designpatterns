using System;
namespace State
{
    public class NoQuarterState : State
    {
        readonly GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
