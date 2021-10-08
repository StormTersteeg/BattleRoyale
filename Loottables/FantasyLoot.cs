using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loottables
{
    public class FantasyLoot : Loottable
    {
        public FantasyLoot() {
            Loot = new List<Equipment>{
                new Equipment("Health Potion", 0, 2, 0, 0),
                new Equipment("Health Potion", 0, 2, 0, 0),
                new Equipment("Health Potion", 0, 2, 0, 0),
                new Equipment("Health Potion", 0, 2, 0, 0),
                new Equipment("Health Potion Max", 0, 6, 0, 0),
                new Equipment("Health Potion Max", 0, 6, 0, 0),
                new Equipment("Amulet of Health", 0, 3, 0, 1),
                new Equipment("Holy Avenger", 5, 0, 20, 0),
                new Equipment("Blackrazor", 5, 0, 20, 0),
                new Equipment("Moonblade", 5, 0, 20, 0),
                new Equipment("Berserker Axe", 4, 0, 10, 0),
                new Equipment("Common Boots", 0, 0, 0, 1),
                new Equipment("Sturdy Boots", 0, 0, 0, 2),
                new Equipment("Sturdy Helm", 0, 0, 0, 2),
                new Equipment("Cape of Health", 0, 2, 0, 2),
                new Equipment("Elven Bow", 3, 0, 10, 0),
                new Equipment("Golden Strider", 3, 0, 0, 0),
                new Equipment("Golden Strider", 3, 0, 0, 0),
                new Equipment("Iron Sword", 2, 0, 40, 0),
                new Equipment("Iron Sword", 2, 0, 40, 0),
                new Equipment("Iron Sword", 2, 0, 40, 0),
                new Equipment("Iron Mace", 3, 0, 20, 0),
                new Equipment("Iron Mace", 3, 0, 20, 0),
                new Equipment("Kings Chestplate", 0, 0, 0, 1),
                new Equipment("Robe", 0, 0, 0, 1),
                new Equipment("Wooden Shield", 1, 0, 0, 1),
                new Equipment("Plated Shield", 1, 0, 0, 2),
                new Equipment("Fire Staff", 5, 0, 0, 0),
                new Equipment("Massive Shield", 0, 0, 0, 5),
                new Equipment("Frost Staff", 5, 0, 0, 0),
                new Equipment("Wooden Dagger", 1, 0, 10, 0),
                new Equipment("Wand of Fireballs", 5, 0, 10, 0),
                new Equipment("Wand of Lightning", 5, 0, 10, 0),
                new Equipment("Spikey Rod", 3, 0, 0, 0),
            };
        }
    }
}
