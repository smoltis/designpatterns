using System;
using System.Text;

namespace State
{
    public class GumballMachine
    {
		private State soldOutState;
        private State noQuarterState;
        private State hasQuarterState;
        private State soldState;
		
        private State state;

		int count = 0;

        public GumballMachine(int numberOfGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.state = soldOutState;

            this.count = numberOfGumballs;
            if(numberOfGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public int GetCount()
        {
            return this.count;
        }

        public void Refill(int cnt)
        {
            this.count = cnt;
            state = noQuarterState;
        }

        public void SetState(State newstate)
        {
            this.state = newstate;
        }

        public State GetState()
        {
            return state;
        }

        public State GetSoldOutState()
        {
            return soldOutState;
        }

        public State GetNoQuarterState()
        {
            return noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public State GetSoldState()
        {
            return soldState;
        }

        public override string ToString() 
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Mighty Gumball, Inc");
            result.AppendLine("C# enabled Standing Gumball Model #2018");
            result.AppendLine($"Inventory {this.count} gumball(s)");
            result.AppendLine("");
            result.AppendLine($"Machine is {state}");
            return result.ToString();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

    }
}
