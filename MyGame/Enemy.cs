using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;


        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string playerName)
        {
            string name = playerName;
            int stringLength = name.Length;


            if (stringLength > 8)
            {
                name = name.Substring(0, 8);
                System.Console.WriteLine(name);
            }
            else
            {
                System.Console.WriteLine(name);

            }
            return name;


        }

        internal void PickupPowerUp(PowerUp powerUp, float i)
        {
            if (powerUp == PowerUp.health)
            {
                health += i;
                if (health > 100)
                    health = 100;

            }
            else if (powerUp == PowerUp.shield)
            {
                shield += 100;
                if (shield > 100)
                    shield = 100;

            }

        }
    }
}