using Loottables;
using Model;
using Maps;
using Controller;
using System;
using System.Collections.Generic;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Field(new ClassicLoot());
            int gameSpeed = 3000;

            // Add players
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\n  Add players! {map.PlayerNames()}\n  Type done when you're done.\n");
                string name = Console.ReadLine();
                if (name!="done" && name!="")
                {
                    map.Players.Add(new Player(name, new List<Equipment>(){ }));
                } else
                {
                    break;
                }
            }
            Console.Clear();

            // Game ticks
            while (true)
            {
                RoundHandler.Round(map, gameSpeed);
                System.Threading.Thread.Sleep(gameSpeed);
                if (map.IsOver()!=null) {break;}
            }

            // Game over
            Console.WriteLine($"\n  {map.IsOver().Name}[{map.IsOver().Health}]");
            map.IsOver().showEquipment();
            map.printScoreboard();
            Console.ReadLine();
        }
    }
}
