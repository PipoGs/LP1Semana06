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
        private Enemy[] Rooms;

        public Level(int NumberOfRooms,enum Toughness)
        {
            NumberOfRooms = NumberOfRooms;
            Toughness = Toughness;
            NumberOfEnemies = 0;
            EnemiesInRoom = new Enemy[NumberOfRooms];
        }

         public void SetEnemyInRoom(int roomNumber, Enemy enemy)
        {

            Rooms[roomNumber] = enemy;
            NumberOfEnemies++; 
        
        }

        public int GetNumberOfRooms()
        {
            return NumberOfRooms;
        }

        public Toughness GetToughness()
        {
            return Toughness;
        }

        public int GetNumEnemies()
        {
            return NumberOfEnemies;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < NumberOfRooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    string roomName = i.ToOrdinalWords(new CultureInfo("en")).Transform(To.TitleCase);
                    Console.WriteLine($"{roomName} room: {Rooms[i].GetName()}");
                }
            }
        }
    }

}