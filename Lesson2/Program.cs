using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int  targetNumber;
            int min = 0, max = 0, attampt = 0, gameCount = 0;

            ConsoleKeyInfo tmp;

            do {
                int number = random.Next(1, 10);
                int currentAttampt = 0;
                gameCount++;

                while (true)
                {
                    currentAttampt++;

                    Console.WriteLine("Enter target number in [1, 10]");
                    while (!int.TryParse(Console.ReadLine(), out targetNumber) || targetNumber < 1 || targetNumber > 10)
                        Console.WriteLine("Error. Enter correct number in [1, 10]");

                    if (targetNumber == number)
                    {
                        Console.WriteLine("You win!!!");
                        break;
                    }

                    if (targetNumber > number)
                        Console.WriteLine("Guess number is less");
                    else
                        Console.WriteLine("Guess number is more");
                }

                attampt += currentAttampt;

                min = min == 0 || min > currentAttampt ? 
                    currentAttampt : min;

                max = max < currentAttampt ? 
                    currentAttampt : max;


                Console.WriteLine("Try again (y/n)");

                tmp = Console.ReadKey();
                Console.WriteLine();

            } while (tmp.Key == ConsoleKey.Y);

            Console.WriteLine($"Min: {min} \nMax: {max} \nAvg: {attampt * 1.0 / gameCount} \nAttempt: {attampt} \nCount Game: {gameCount}");
            Console.ReadLine();
        }
    }
}
