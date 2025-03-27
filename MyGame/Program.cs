using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numberOfEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numberOfEnemies];
            Console.WriteLine($"{numberOfEnemies}");
        }
    }
}
