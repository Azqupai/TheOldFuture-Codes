using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace DoNotRun {
	
    class Program {
		
        static void Main(string[] args) {
			
            System.Windows.Forms.MessageBox.Show("Not again!");
            Console.WriteLine("So it’s you again!");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Seems like I have to do this all over again.");
            System.Threading.Thread.Sleep(3000);
            Process.Start("cmd", "/C echo System.Shutdown && pause");
        }
    }
}