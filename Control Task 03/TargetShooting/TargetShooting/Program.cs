using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetShooting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;

            while (true)
            {
                Console.Write("Do the first shoot (from 0 to 3): ");
                int x = int.Parse(Console.ReadLine());

                if (x == -1)
                {
                    break;
                }

                Console.Write("Do the second shoot (from 0 to 3)");
                int y = int.Parse(Console.ReadLine());

                int points = CalculatePoints(x, y);
                totalPoints += points;

                Console.WriteLine($"You earned {points} points. Total number of points: {totalPoints}\n");
            }
            Console.WriteLine($"Total number of points: {totalPoints}");
        }

        static int CalculatePoints(int x, int y)
        {
            if (x >= 0 && x <= 1 && y >= 0 && y <= 3)
            {
                return 10;
            }
            else if (x > 1 && x <= 2 && y >= 0 && y <= 3)
            {
                return 5;
            }
            else if (x > 2 && x <= 3 && y >= 0 && y <= 3)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Incorrect coordinates. Please, try again.");
                return 0;
            }
        }
    }
}