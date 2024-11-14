using System;
using System.Threading;

class Program {

	static void Main() {
		
		Console.WriteLine("Do you want to continue? (yes/no)");
		string input = Console.ReadLine();
		
		if (input.ToLower() == "no") {
			
			Console.Clear();
			Console.WriteLine("Goodbye then!");
			Thread.Sleep(2000);
			Environment.Exit(0);
		}
		
		else if (input.ToLower() == "yes") {
			
			Console.Clear();
			Console.WriteLine("Welcome to TheOldProject!");
			Thread.Sleep(2000);
			Console.WriteLine("Oh wait, it's not done yet. Check back later!");
			Thread.Sleep(2000);
			Environment.Exit(0);
			
		}
		
		else {
			
			Console.WriteLine("Invalid input. Exiting...");
			Thread.Sleep(3000);
			Environment.Exit(1);
			
		}
		
		Console.WriteLine("Press any key to exit.");
		Console.ReadKey();
		
	}
	
}