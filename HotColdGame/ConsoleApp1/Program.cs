using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random randomNumber = new Random();
                int number = randomNumber.Next(0, 101);
                Console.WriteLine("What is the random number?");
                int guess = 0;
                int guessCount = 0;
                while (number != guess)
                {

                    string guessString = Console.ReadLine();
                    bool isValid = Int32.TryParse(guessString, out guess);
                    int value = Math.Abs(number - guess);
                    int availableRangeEnd = 20;
                    int availableRangeBegin = 10;
                    int availableRangeHot = 5;
                    int availableRangeBurn = 1;
                    guessCount++;

                    if (isValid)
                    {
                        if (value >= availableRangeBegin && value <= availableRangeEnd)
                        {
                            Console.WriteLine("Warm, Not bad try again");
                        }
                        else if (value <= availableRangeBegin && value >= availableRangeHot)
                        {
                            Console.WriteLine("Hot, Nice try, Try again ");
                        }
                        else if (value >= availableRangeBurn && value <= availableRangeHot)
                        {
                            Console.WriteLine("BURN, Almost you find it !!");
                        }
                        else if (value == 0)
                        {
                            Console.WriteLine("You Done It ! Play again for better result :) You found the correct answer at " + guessCount + " times");
                            if (guessCount > 5)
                            {
                                Console.WriteLine("You should work more :(");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cold. Try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter just number.");
                        Console.WriteLine("What is the random number?");
                    }

                }
            }



        }
    }
}
