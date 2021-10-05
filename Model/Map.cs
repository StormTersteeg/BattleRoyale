using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class Map
    {
        public int round_count {get;set;} = 1;
        public List<Player> Players {get;set;} = new List<Player>(){};
        public Loottable Loot {get;set;} = new Loottable();

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

        public Player IsOver()
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
