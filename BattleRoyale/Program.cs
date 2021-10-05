using Loottables;
using System;
using System.Collections.Generic;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> new_players = new List<Player>(){ };
            Field field = new Field(new ClassicLoot());

            // Add players
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\n  Add players! {field.PlayerNames()}\n  Type done when you're done.\n");
                string name = Console.ReadLine();
                if (name!="done" && name!="")
                {
                    field.Players.Add(new Player(name, new List<Equipment>(){ }));
                } else
                {
                    break;
                }
            }
            Console.Clear();

            // Game ticks
            while (true)
            {
                field.Round(3000);
                System.Threading.Thread.Sleep(3000);
                if (field.IsOver()!=null) {break;}
            }
            Console.WriteLine($"\n  {field.IsOver().Name}[{field.IsOver().Health}]");
            field.IsOver().showEquipment();
            field.printScoreboard();
            Console.ReadLine();
        }
    }
}
