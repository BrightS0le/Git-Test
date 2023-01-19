using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hunter Johnson 
//1/19/2023
//brief: It's a number guessing game
//Description: Takes in two user inputs for an upper and lower bound then generates a random number between
//the two and then proceeds to stimulate and extract guesses from the user until the correct one is obtained
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
            Console.WriteLine("Please enter a number for the minimum value...");
            int lower = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for the maximum value...");
            int upper = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int n = rnd.Next(lower, upper);
            int userNum;
            Console.WriteLine("I am thinking of a number between " + lower + " and " + upper + "...");
            userNum = int.Parse(Console.ReadLine());
            while (userNum != n)
            {
                if (userNum < n)
                {
                    Console.WriteLine("Higher. Please enter a new number...");
                }
                if (userNum > n)
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
