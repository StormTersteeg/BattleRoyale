using Controller;
using Model;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace BattleRoyale
{
    public class Field : Map
    {
        public Field(Loottable Loot)
        {
            this.Loot = Loot;
        }

        public void Carepackage(Player Player)
        {
            if (Loot.Count()>2)
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] found a carepackage.");
                Loot.playerLoot(Player);
                Loot.playerLoot(Player);
                Loot.playerLoot(Player);
            } else
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] is roaming.");
            }
        }

        public void playerRoam(Player Player)
        {
            int chance = RandomNumberGenerator.GetInt32(0,13);

            switch (chance)
            {
                case var expression when (chance >= 0 && chance < 6):
                    CombatHandler.Fight(Player, RandomPlayer(Player));
                    break;
                case var expression when (chance >= 6 && chance < 9):
                    Loot.playerLoot(Player);
                    break;
                case var expression when (chance >= 9 && chance < 11):
                    Player.Rest();
                    break;
                case var expression when (chance >= 11 && chance < 12):
                    CombatHandler.Ambush(Player, RandomPlayer(Player));
                    break;
                case var expression when (chance >= 12 && chance < 13):
                    Carepackage(Player);
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
                    if (IsOver()!=null) {break;}
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
    }
}
