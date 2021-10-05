using BattleRoyale;
using Controller;
using Model;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Maps
{
    public class MinecraftMap : Map
    {
        public MinecraftMap(Loottable Loot)
        {
            this.Loot = Loot;
        }

        public void Creeper(Player Player)
        {
            Player.Hurt(5);
            if (Player.Health>0)
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] survived a creeper explosion.");
            } else
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] was exploded by a creeper.");
            }
        }

        public void Zombie(Player Player)
        {
            Player.Hurt(2);
            if (Player.Health>0)
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] killed a Zombie.");
            } else
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] was killed by a Zombie.");
            }
        }

        public void Treasure(Player Player)
        {
            if (Loot.Count()>1)
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] found a treasure chest.");
                Loot.playerLoot(Player);
                Loot.playerLoot(Player);
            } else
            {
                Console.WriteLine($"  {Player.Name}[{Player.Health}] is roaming.");
            }
        }

        public override void playerRoam(Player Player)
        {
            int chance = RandomNumberGenerator.GetInt32(0,14);

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
                    Creeper(Player);
                    break;
                case var expression when (chance >= 13 && chance < 14):
                    Zombie(Player);
                    break;
                default:
                    break;
            }
        }
    }
}
