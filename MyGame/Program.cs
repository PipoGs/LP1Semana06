using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for (int numberOfEnemies = 0; numberOfEnemies < int.Parse(args[0]); numberOfEnemies++)
            {

                Console.Write($"Nome do inimigo {numberOfEnemies + 1}: ");
                enemies[numberOfEnemies] = new Enemy(Console.ReadLine());

            }

        }
    }
}
