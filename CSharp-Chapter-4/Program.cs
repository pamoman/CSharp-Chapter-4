using System;

namespace CSharp_Chapter_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Programmering";
            char letter = 'm';
            bool found = false;
            int count = 0;

            // Kör loopen 15 gånger, i börjar på 0 och slutar på 14
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter)
                {
                    found = true;
                    count++;
                }
            }

            if (found)
            {
                Console.WriteLine($"Hittades {count}st bokstaven {letter}");
            }
            else
            {
                Console.WriteLine($"{letter} hittades inte");
            }
        }
    }
}
