using System.Collections.Generic;
using System.Threading;
using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("  ___              _    _    _       ___                     ");
            Console.WriteLine(" / __| __ _ _ __ _| |__| |__| |___  / __| __ ___ _ _ ___ _ _ ");
            Console.WriteLine(" \\__ \\/ _| '_/ _` | '_ \\ '_ \\ / -_) \\__ \\/ _/ _ \\ '_/ -_) '_|");
            Console.WriteLine(" |___/\\__|_| \\__,_|_.__/_.__/_\\___| |___/\\__\\___/_| \\___|_|  ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Enter an Word in English");
            Console.WriteLine("and Get a Score!");
            Console.WriteLine(" ");
            string userInput = Console.ReadLine();
            Console.WriteLine(" ");
            {
                ShowSimplePercentage();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
        }
    }
}