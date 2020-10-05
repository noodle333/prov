using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            int ship = 4;
            int player_guess = 0;
            int loop = 1;

            Console.WriteLine("Det här är spelet sänka skepp.");
            Console.WriteLine("Målet med spelet är att sänka skeppet genom att gissa på en x kordinat mellan 1-10.");
            Console.WriteLine("Gissa på en x kordinat mellan 1-10.");

            while (loop == 1)
            {
                player_guess = Convert.ToInt32(Console.ReadLine());

                if (player_guess == ship)
                {
                    Console.WriteLine("Hit! Du sänkte skeppet!");
                    loop = loop - 1;
                }
                else if (player_guess < ship + 3 && player_guess > ship - 3)
                {
                    Console.WriteLine("Near miss! Försök igen!");
                }
                else if (player_guess > ship + 2 || player_guess == 1)
                {
                    Console.WriteLine("Miss! Försök igen!");
                }
                else
                {
                    Console.WriteLine("Incorrect input. Skriv en siffra mellan 1-10.");
                }

            }
            Console.WriteLine("Du sänkte skeppet och vann!");
            Console.ReadLine();

        }
    }
}

