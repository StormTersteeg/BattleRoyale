using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale
{
    class Field
    {
        public int round_count {get;set;} = 1;
        public List<Player> Players {get;set;}

        public List<Equipment> Loot {get;set;} = new List<Equipment>() {
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
        };

        public Field(List<Player> Players)
        {
            this.Players = Players;
        }

        public string PlayerNames()
        {
            List<string> string_list = new List<string>(){};
            foreach (Player player in Players)
            {
                string_list.Add(player.Name);
            }
            return string.Join(", ", string_list);
        }

        public Player RandomPlayer()
        {
            Player random_player = Players[new Random().Next(Players.Count)];
            while (true)
            {
                random_player = Players[new Random().Next(Players.Count)];
                if (random_player.Health>0) break;
            }
            return random_player;
        }

        public Player RandomPlayer(Player Player)
        {
            Player random_player = Players[new Random().Next(Players.Count)];
            while (true)
            {
                random_player = Players[new Random().Next(Players.Count)];
                if (random_player.Health>0 && Player!=random_player) break;
            }
            return random_player;
        }

        public int PlayersAlive()
        {
            int count = 0;
            foreach (Player p in Players){
                if (p.Health>0) {count++;}
            }
            return count;
        }

        public Player isWinner()
        {
            int count = 0;
            int i = 0;
            int alive = -1;
            foreach (Player p in Players){
                if (p.Health>0) {count++; alive = i;}
                i++;
            }
            return (count==1) ? Players[alive] : null;
        }

        public void Fight(Player a, Player b)
        {
            string toPrint;

            b.Hurt(a.BestFightEquipment().Damage());
            if (b.Health<=0)
            {
                toPrint = $"  {a.Name}[{a.Health}] killed {b.Name}[{b.Health}] using their {a.BestFightEquipment().Name}.";
                a.Kills++;
                foreach (Equipment e in b.Equipment) {a.Equipment.Add(e);}
            } else
            {
                a.Hurt(b.BestFightEquipment().Damage());
                if (a.Health<=0)
                {
                    toPrint = $"  {b.Name}[{b.Health}] killed {a.Name}[{a.Health}] using their {b.BestFightEquipment().Name}.";
                    b.Kills++;
                    foreach (Equipment e in a.Equipment) {b.Equipment.Add(e);}
                } else
                {
                    toPrint = $"  {a.Name}[{a.Health}] and {b.Name}[{b.Health}] fight.";
                }
            }

            Console.WriteLine(toPrint);
        }

        public void Ambush(Player a, Player b)
        {
            string toPrint = "";

            b.Hurt(a.BestFightEquipment().Damage());
            if (b.Health<=0)
            {
                toPrint = toPrint + $"  {a.Name}[{a.Health}] ambushed and killed {b.Name}[{b.Health}] using their {a.BestFightEquipment().Name}.";
                a.Kills++;
                foreach (Equipment e in b.Equipment) {a.Equipment.Add(e);}
            } else
            {
                toPrint = toPrint + $"  {a.Name}[{a.Health}] ambushed {b.Name}[{b.Health}].";
            }
            Console.WriteLine(toPrint);
        }


        public void playerLoot(Player player)
        {
            if (Loot.Count>0)
            {
                int num = new Random().Next(Loot.Count);
                Equipment equipment = Loot[num];
                player.Equipment.Add(equipment);
                Console.WriteLine($"  {player.Name}[{player.Health}] found {equipment.Name}.");
                Loot.RemoveAt(num);
            } else
            {
                Console.WriteLine($"  {player.Name}[{player.Health}] is roaming.");
            }
        }

        public void Airdrop(Player player)
        {
            if (Loot.Count>2)
            {
                Console.WriteLine($"  {player.Name}[{player.Health}] found a carepackage.");
                playerLoot(player);
                playerLoot(player);
                playerLoot(player);
            } else
            {
                Console.WriteLine($"  {player.Name}[{player.Health}] is roaming.");
            }
        }

        public void playerRoam(Player Player)
        {
            int chance = RandomNumberGenerator.GetInt32(0,13);

            switch (chance)
            {
                case var expression when (chance >= 0 && chance < 6):
                    Fight(Player, RandomPlayer(Player));
                    break;
                case var expression when (chance >= 6 && chance < 9):
                    playerLoot(Player);
                    break;
                case var expression when (chance >= 9 && chance < 11):
                    Player.Rest();
                    break;
                case var expression when (chance >= 11 && chance < 12):
                    Ambush(Player, RandomPlayer(Player));
                    break;
                case var expression when (chance >= 12 && chance < 13):
                    Airdrop(Player);
                    break;
                default:
                    break;
            }
        }

        public void Round(int timeout)
        {
            Players = Players.OrderBy( x => new Random().Next() ).ToList( );
            Console.WriteLine($"\n  Round {round_count} : Alive {PlayersAlive()}");
            try
            {
                foreach (Player Player in Players)
                {
                    if (isWinner()!=null) {break;}
                    if (Player.Health>0)
                    {
                        System.Threading.Thread.Sleep(timeout);
                        playerRoam(Player);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            round_count++;
        }

        public void printScoreboard()
        {
            Players = Players.OrderBy(o=>o.Kills).ToList();
            Players.Reverse();
            Console.WriteLine(String.Format("\n  Leaderboard\n  {0,-17}{1,-17}{2,-17}", "Player", "Kills", "Loot"));
            foreach (Player player in Players)
            {
                Console.WriteLine(String.Format("  {0,-17}{1,-17}{2,-17}", player.Name, player.Kills, player.Equipment.Count));
            }
        }
    }
}
