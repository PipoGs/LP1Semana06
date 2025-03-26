using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random(int.Parse(args[1]));

            int n = 0;
            int M = 0;

            while (n < int.Parse(args[0]))
            {
                M += random.Next(1, 7);
                n++;
            }

            Console.WriteLine(M);
        }
    }
}
