namespace CommandPattern
{

    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }

        public void Execute()
        {
            System.Console.WriteLine("Couldn't find command: " + Name);
        }
 
    }
}