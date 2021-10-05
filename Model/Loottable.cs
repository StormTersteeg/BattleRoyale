using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleRoyale
{
    public class Loottable
    {
        public List<Equipment> Loot {get;set;}

        public int Count()
        {
            return Loot.Count();
        }

        public void RemoveAt(int location)
        {
            Loot.RemoveAt(location);
        }

        public Equipment GetAt(int location)
        {
            return Loot[location];
        }

        public void playerLoot(Player player)
        {
            if (Loot.Count()>0)
            {
                int num = new Random().Next(Loot.Count());
                Equipment equipment = this.GetAt(num);
                player.Equipment.Add(equipment);
                Console.WriteLine($"  {player.Name}[{player.Health}] found {equipment.Name}.");
                Loot.RemoveAt(num);
            } else
            {
                Console.WriteLine($"  {player.Name}[{player.Health}] is roaming.");
            }
        }
    }
}
