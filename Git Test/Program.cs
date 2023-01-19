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
            Console.WriteLine("Would you like to play a number guessing game? (y or n)");
            v = Console.ReadLine();
            if (v == "n")
            {
                Console.WriteLine("That's a shame...");
                Console.ReadKey();
                return;
            }
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            int userNum = 0;
            Console.WriteLine("I am thinking of a number between 1 and 100...");
            userNum = int.Parse(Console.ReadLine());
            while (userNum != n)
            {
                if (userNum < n)
                {
                    Console.WriteLine("Higher. Please enter a new number...");
                }
                if(userNum > n)
                {
                    Console.WriteLine("Lower. Please enter a new number...");
                }
                userNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations! You got it the number was " + n + "!");
            Console.ReadKey();
        }
    }
}
