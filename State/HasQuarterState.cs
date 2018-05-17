using System;
namespace State
{
    public class HasQuarterState : State
    {
        readonly GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }
        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
