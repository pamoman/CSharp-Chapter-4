using System;
using System.Threading;

namespace CSharp_Chapter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett meddelande");
            string text = Console.ReadLine();

            Console.WriteLine("Hur länge vänta mellan varje tecken (s)?");
            int len = int.Parse(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(1000 * len);
            }
        }
    }
}
