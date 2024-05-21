using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 1.4");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PART 1");
            Console.ForegroundColor = ConsoleColor.White;

            // StartPoint label for looping
            StartPoint:

            //creates P1 and P2 points
            Point P1 = new Point();
            Point P2 = new Point();

            // P1
            Console.WriteLine("\nEnter the coordinates for P1: ");
            Console.Write("X: ");
            P1.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            P1.Y = int.Parse(Console.ReadLine());

            // P2
            Console.WriteLine("\nEnter the coordinates for P2: ");
            Console.Write("X: ");
            P2.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            P2.Y = int.Parse(Console.ReadLine());

            // internal print
            //Console.WriteLine($"Your P1 is ({P1.X},{P1.Y})");
            //Console.WriteLine($"Your P2 is ({P2.X},{P2.Y})");

            // P2 left of P1
            if (P2.X < P1.X)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nP2 is left of P1");
                Console.ForegroundColor = ConsoleColor.White;

            }

            // P2 right of P1
            if (P2.X > P1.X)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nP2 is right of P1");
                Console.ForegroundColor = ConsoleColor.White;

            }

            // P1 & P2 on same x cord
            if (P2.X == P1.X)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nP1 and P2 are on the same Y axis");
                Console.ForegroundColor = ConsoleColor.White;

            }

            // have to create while loop to be able to use break and continue
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char choice = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (choice == 'Y')
                {
                    goto StartPoint;
                }

                // does not want to continue
                else if (choice == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            // CLOSIING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();

        }
    }
}
