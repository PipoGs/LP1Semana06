using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace MyRoguelike
{

    public class Level
    {
        private int NumberOfRooms;
        private int Toughness;
        private Enemy[] rooms;

        public Level(int NumberOfRooms,enum Toughness)
        {
            toughness = Toughness;
            Rooms = new Enemy[NumberOfRooms];
          
        }

         public void SetEnemyInRoom(int roomNumber, Enemy enemy)
        {

            rooms[roomNumber] = enemy;
        
        }

        public int GetNumberOfRooms()
        {
            return NumberOfRooms;
        }

        public int GetToughness()
        {
            return Toughness;
        }

        public int GetNumEnemies()
        {
            return NumberOfEnemies;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i.ToWords()} room: {rooms[i].GetName()}");
                }
            }
        }
    }

}