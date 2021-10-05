using System;
using System.Collections.Generic;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> new_players = new List<Player>(){ };
            Field field = new Field(new List<Player>(){ });

            // Add players
            string response = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\n  Add players! {field.PlayerNames()}\n  Type done when you're done.\n");
                string name = Console.ReadLine();
                if (name!="done")
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
                if (field.isWinner()!=null) {break;}
            }
            Console.WriteLine($"\n  {field.isWinner().Name}[{field.isWinner().Health}]");
            field.isWinner().showEquipment();
            field.printScoreboard();
            Console.ReadLine();
        }
    }
}
