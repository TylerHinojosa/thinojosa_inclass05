using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinojosa_inclass05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int rNumber;
            const int MIN = 1;
            const int MAX = 10;

            rNumber = rng.Next(MIN, MAX + 1);

            Console.WriteLine(rNumber);

            Console.Write("Enter a number between {0} and {1}: ", MIN, MAX);
            int answer = Convert.ToInt32(Console.ReadLine());

            if(answer < MIN || answer > MAX)
            {
                Console.WriteLine("Your answer must be between {0} and {1}.", MIN, MAX);
            }
            if(answer < rNumber)
            {
                Console.WriteLine("The answer was {0}. Your answer was too low.", rNumber);
            }
            else if(answer > rNumber)
            {
                Console.WriteLine("The answer was {0}. Your answer was too high.", rNumber);
            }
            else
            {
                Console.WriteLine("Your answer was correct!");
            }
            Console.Write("What grade would you like to get in this class? ");
            string grade = Console.ReadLine();
            switch(grade)
            {
                case "A":
                    Console.WriteLine("you're going to do great!");
                    break;
                case "B":
                    Console.WriteLine("You will do just fine.");
                    break;
                case "C":
                    Console.WriteLine("That's not so bad.");
                    break;
                case "D":
                    Console.WriteLine("Alright");
                    break;
                case "F":
                    Console.WriteLine("I hope that's not what you really wanted.");
                    break;
                default:
                    Console.WriteLine("I don't understand that...");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
