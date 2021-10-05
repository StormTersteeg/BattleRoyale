using Loottables;
using System;
using System.Collections.Generic;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field(new ClassicLoot());
            int gameSpeed = 3000;

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
                field.Round(gameSpeed);
                System.Threading.Thread.Sleep(gameSpeed);
                if (field.IsOver()!=null) {break;}
            }

            // Game over
            Console.WriteLine($"\n  {field.IsOver().Name}[{field.IsOver().Health}]");
            field.IsOver().showEquipment();
            field.printScoreboard();
            Console.ReadLine();
        }
    }
}
