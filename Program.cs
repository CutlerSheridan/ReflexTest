using System;
using System.Diagnostics;
using System.Threading;

namespace ReflexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nWelcome to Reflex Test.\nWhen \"Now!\" appears on the screen, press enter.\nPress enter to begin.  ");
            while (true)
            {
                Console.ReadLine();
                GameStart();
                Console.WriteLine("Press enter to try again or x to exit the program.");
                string input = Console.ReadLine();
                if (input != "")
                {
                    break;
                }
                Console.Write("Ready?  ");
            }
        }

        static void GameStart()
        {
            Random rand = new Random();
            Stopwatch timer = new Stopwatch();
            Thread.Sleep(rand.Next(750, 5000));
            Console.Write("\nNow!  ");
            timer.Start();
            Console.ReadLine();
            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"\n\nYou reacted in {elapsedTime} seconds!\n");
        }
    }
}
