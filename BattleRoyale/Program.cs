using System;
using System.Collections.Generic;

namespace BattleRoyale
{
    class Program
    {
        static void Main(string[] args)
        {
            Loottable classic_loot = new Loottable(new List<Equipment>{
                new Equipment("Knife", 2, 0, 0, 0),
                new Equipment("Knife", 2, 0, 0, 0),
                new Equipment("Knife", 2, 0, 0, 0),
                new Equipment("Machete", 3, 0, 0, 0),
                new Equipment("Crowbar", 3, 0, 5, 0),
                new Equipment("Bandage", 0, 2, 0, 0),
                new Equipment("Bandage", 0, 2, 0, 0),
                new Equipment("Bandage", 0, 2, 0, 0),
                new Equipment("Canned Food", 0, 2, 0, 0),
                new Equipment("Canned Food", 0, 2, 0, 0),
                new Equipment("Canned Food", 0, 2, 0, 0),
                new Equipment("Helmet", 0, 0, 0, 1),
                new Equipment("Tactical Gloves", 0, 0, 0, 1),
                new Equipment("Light Armor", 0, 0, 0, 1),
                new Equipment("Medium Armor", 0, 0, 0, 2),
                new Equipment("Heavy Armor", 0, 0, 0, 4),
                new Equipment("Riot Shield", 2, 0, 0, 2),
                new Equipment("Medkit", 0, 4, 0, 0),
                new Equipment("RPG", 7, 0, 0, 0),
                new Equipment("L118A", 4, 0, 70, 0),
                new Equipment("Barrett 50CAL", 7, 0, 0, 0),
                new Equipment("Minigun", 7, 0, 50, 0),
                new Equipment("AK47", 4, 0, 30, 0),
                new Equipment("M16", 4, 0, 15, 0),
                new Equipment("MP9", 3, 0, 15, 0),
                new Equipment("Skorpion", 3, 0, 15, 0),
                new Equipment("Five Seven", 4, 0, 10, 0),
                new Equipment("Scar L", 6, 0, 0, 0),
                new Equipment("Deagle", 5, 0, 5, 0)
            });
            List<Player> new_players = new List<Player>(){ };
            Field field = new Field(classic_loot);

            // Add players
            string response = "";
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
                if (field.isWinner()!=null) {break;}
            }
            Console.WriteLine($"\n  {field.isWinner().Name}[{field.isWinner().Health}]");
            field.isWinner().showEquipment();
            field.printScoreboard();
            Console.ReadLine();
        }
    }
}
