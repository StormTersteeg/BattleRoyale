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
                new Equipment("Health Potion", 0, 0, 2, 0),
                new Equipment("Health Potion", 0, 0, 2, 0),
                new Equipment("Health Potion", 0, 0, 2, 0),
                new Equipment("Health Potion", 0, 0, 2, 0),
                new Equipment("Health Potion Max", 0, 0, 6, 0),
                new Equipment("Health Potion Max", 0, 0, 6, 0),
                new Equipment("Amulet of Health", 0, 0, 3, 1),
                new Equipment("Holy Avenger", 5, 20, 0, 0),
                new Equipment("Blackrazor", 5, 20, 0, 0),
                new Equipment("Moonblade", "{a.Name}[{a.Health}] struck {b.Name}[{b.Health}] using their {eq.Name}.", 5, 20, 0, 0),
                new Equipment("Berserker Axe", "{a.Name}[{a.Health}] sliced {b.Name}[{b.Health}] using their {eq.Name}.", 4, 10, 0, 0),
                new Equipment("Common Boots", 0, 0, 0, 1),
                new Equipment("Sturdy Boots", 0, 0, 0, 2),
                new Equipment("Sturdy Helm", 0, 0, 0, 2),
                new Equipment("Cape of Health", 0, 0, 2, 2),
                new Equipment("Elven Bow", "{a.Name}[{a.Health}] shot {b.Name}[{b.Health}] using their {eq.Name}.", 4, 10, 0, 0),
                new Equipment("Long Bow", "{a.Name}[{a.Health}] shot {b.Name}[{b.Health}] using their {eq.Name}.", 3, 10, 0, 0),
                new Equipment("Golden Strider", 3, 0, 0, 0),
                new Equipment("Golden Strider", 3, 0, 0, 0),
                new Equipment("Iron Sword", 2, 40, 0, 0),
                new Equipment("Iron Sword", 2, 40, 0, 0),
                new Equipment("Iron Sword", 2, 40, 0, 0),
                new Equipment("Iron Mace", 3, 20, 0, 0),
                new Equipment("Iron Mace", 3, 20, 0, 0),
                new Equipment("Kings Chestplate", 0, 0, 0, 1),
                new Equipment("Robe", 0, 0, 0, 1),
                new Equipment("Wooden Shield", 1, 0, 0, 1),
                new Equipment("Plated Shield", 1, 0, 0, 2),
                new Equipment("Fire Staff", "{a.Name}[{a.Health}] burned {b.Name}[{b.Health}] to a crisp using their {eq.Name}.", 5, 0, 0, 0),
                new Equipment("Massive Shield", 0, 0, 0, 5),
                new Equipment("Frost Staff", "{a.Name}[{a.Health}] froze {b.Name}[{b.Health}] to death using their {eq.Name}.", 5, 0, 0, 0),
                new Equipment("Wooden Dagger", "{a.Name}[{a.Health}] stabbed {b.Name}[{b.Health}] using their {eq.Name}.", 1, 10, 0, 0),
                new Equipment("Wand of Fireballs", "{a.Name}[{a.Health}] burned {b.Name}[{b.Health}] to a crisp using their {eq.Name}.", 5, 10, 0, 0),
                new Equipment("Wand of Fireballs", "{a.Name}[{a.Health}] burned {b.Name}[{b.Health}] to a crisp using their {eq.Name}.", 5, 10, 0, 0),
                new Equipment("Spikey Rod", 3, 0, 0, 0),
            };
        }
    }
}
