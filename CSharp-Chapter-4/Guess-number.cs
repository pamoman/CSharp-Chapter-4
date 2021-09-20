using System;

namespace CSharp_Chapter_4
{
    class GuessNumberGame
    {
        static void GuessGame(string[] args)
        {
            int min = 1;
            int max = 100;

            Random random = new Random();

            int randNum = random.Next(min, max);

            //Console.WriteLine(randNum);

            Console.WriteLine("Gissa nummer mellan 1 och 100!");

            int user = int.Parse(Console.ReadLine());

            while (user != randNum)
            {
                Console.WriteLine("Fel, försök igen!");
                user = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Du svarade rätt, nummer {randNum}");
        }
    }
}
