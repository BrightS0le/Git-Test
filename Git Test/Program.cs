using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string v;
            Console.WriteLine("Please kill me, *cough* *cough* I mean Hello World!");
            Console.WriteLine("I am not smart enough for this...");
            Console.WriteLine("For the next values please enter a lower and upper bound for a number guessing game respectively...");
            Console.Write("Enter the value for x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the value for y:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("X:" + x + " Y:" + y);
            Console.ReadKey();
        }
    }
}
