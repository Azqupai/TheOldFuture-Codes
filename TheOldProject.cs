using System;
using System.Threading;

class Program {

    static void Main(string[] args) {
	
        Console.WriteLine("Do you want to continue? (yes/no)");
        string input = Console.ReadLine();

        if (input.Equals("no", StringComparison.OrdinalIgnoreCase)) {
		
            Console.Clear();
            Console.WriteLine("Goodbye then.");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        else if (input.Equals("yes", StringComparison.OrdinalIgnoreCase)) {
		
            Console.Clear();
            Console.WriteLine("Welcome to TheOldProject.");
            Thread.Sleep(1000);
            Console.WriteLine("This is =Azqual7's first code written in 2006!");
            Thread.Sleep(1000);
            Console.WriteLine("Yeah, I'm a developer, a very special one.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("...Unfortunately right now there are no commands I have coded in for you to type :)");
            Thread.Sleep(2000);
            Console.WriteLine("...Maybe check after a week or so for new commands, I guess...");
            Thread.Sleep(2000);
        }
    }
}