using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loottables
{
    public class MinecraftLoot : Loottable
    {
        public MinecraftLoot() {
            this.Loot = new List<Equipment>{
                new Equipment("Netherite Sword", 8, 0, 0, 0),
                new Equipment("Diamond Sword", 7, 0, 0, 0),
                new Equipment("Iron Sword", 6, 0, 0, 0),
                new Equipment("Stone Sword", 5, 0, 0, 0),
                new Equipment("Golden Sword", 4, 0, 0, 0),
                new Equipment("Wooden Sword", 4, 0, 0, 0),
                new Equipment("Netherite Axe", 8, 0, 0, 0),
                new Equipment("Diamond Axe", 7, 0, 0, 0),
                new Equipment("Iron Axe", 6, 0, 0, 0),
                new Equipment("Stone Axe", 5, 0, 0, 0),
                new Equipment("Golden Axe", 4, 0, 0, 0),
                new Equipment("Wooden Axe", 4, 0, 0, 0),
                new Equipment("Trident", 8, 0, 0, 0),
                new Equipment("Bow", 6, 0, 0, 0),
                new Equipment("Crossbow", 9, 0, 0, 0),
                new Equipment("Iron Helmet", 0, 0, 0, 1),
                new Equipment("Iron Chestplate", 0, 0, 0, 2),
                new Equipment("Iron Leggings", 0, 0, 0, 2),
                new Equipment("Iron Boots", 0, 0, 0, 1),
                new Equipment("Diamond Helmet", 0, 0, 0, 2),
                new Equipment("Diamond Chestplate", 0, 0, 0, 3),
                new Equipment("Diamond Leggings", 0, 0, 0, 3),
                new Equipment("Diamond Boots", 0, 0, 0, 2),
                new Equipment("Apple", 0, 2, 0, 0),
                new Equipment("Apple", 0, 2, 0, 0),
                new Equipment("Bread", 0, 2, 0, 0),
                new Equipment("Bread", 0, 2, 0, 0),
                new Equipment("Steak", 0, 5, 0, 0),
                new Equipment("Steak", 0, 5, 0, 0),
                new Equipment("Baked Potato", 0, 4, 0, 0),
                new Equipment("Baked Potato", 0, 4, 0, 0),
                new Equipment("Shield", 0, 0, 0, 2),
                new Equipment("Shield", 0, 0, 0, 2)
            };
        }
    }
}
