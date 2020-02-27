/**
 This dumb program is completely free to modify (and distribute modified versions) as long as you keep the link to the original
*/
using System;
using System.Threading;
namespace revenge_cli
{
    class Program
    {
		static void Lyrics(){
            Console.Write("Creeper... ");
			Thread.Sleep(2000);
			Console.Write("Aww ");
			Thread.Sleep(1000);
			Console.WriteLine("man...");

			Thread.Sleep(2000);
			Console.Write("So we back ");
			Thread.Sleep(1000);
			Console.WriteLine("in the mine");
			Thread.Sleep(1000);
			
			Console.Write("Got ");
			Thread.Sleep(300);
			Console.Write("our ");
			Thread.Sleep(300);
			Console.Write("pick");
			Thread.Sleep(300);
			Console.Write("axe ");
			Thread.Sleep(300);
			Console.Write("swing");
			Thread.Sleep(300);
			Console.Write("ing ");
			Thread.Sleep(300);
			Console.Write("from ");
			Thread.Sleep(700);
			Console.Write("side ");
			Thread.Sleep(700);
			Console.Write("to ");
			Thread.Sleep(700);
			Console.WriteLine("side.");

			
			Thread.Sleep(700);
			Console.Write("Side-");
			Thread.Sleep(200);
			Console.Write("Side ");
			Thread.Sleep(200);
			Console.Write("to ");
			Thread.Sleep(400);
			Console.WriteLine("Side.");
		}
		static void Main(string[] args)
        {
			Console.Clear();
			Console.WriteLine("-- START -- ");
			Lyrics();
			Console.WriteLine("--  END  -- ");
			Thread.Sleep(5000);
        }
    }
}
