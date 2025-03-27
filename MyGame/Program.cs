using System;
using MyGame;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numberOfEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numberOfEnemies];

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();

                Enemy enemy = new Enemy("");
                enemy.SetName(enemyName);
                enemies[i] = enemy;

            }

            foreach (Enemy newEnemy in enemies)
            {
                newEnemy.TakeDamage(15);
                newEnemy.PickupPowerUp(PowerUp.health, 5);
                newEnemy.PickupPowerUp(PowerUp.shield, 500);
                Console.WriteLine($"{newEnemy.GetName()} {newEnemy.GetHealth()} {newEnemy.GetShield()}");

            }

        }
    }
}
