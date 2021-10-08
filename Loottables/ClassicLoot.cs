using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loottables
{
    public class ClassicLoot : Loottable
    {
        public ClassicLoot() {
            Loot = new List<Equipment>{
                new Equipment("Knife", "{a.Name}[{a.Health}] stabbed {b.Name}[{b.Health}] using their {eq.Name}.", 2, 0, 0, 0),
                new Equipment("Knife", "{a.Name}[{a.Health}] stabbed {b.Name}[{b.Health}] using their {eq.Name}.", 2, 0, 0, 0),
                new Equipment("Knife", "{a.Name}[{a.Health}] stabbed {b.Name}[{b.Health}] using their {eq.Name}.", 2, 0, 0, 0),
                new Equipment("Machete", 3, 0, 0, 0),
                new Equipment("Crowbar", 3, 5, 0, 0),
                new Equipment("Bandage", 0, 0, 2, 0),
                new Equipment("Bandage", 0, 0, 2, 0),
                new Equipment("Bandage", 0, 0, 2, 0),
                new Equipment("Canned Food", 0, 0, 2, 0),
                new Equipment("Canned Food", 0, 0, 2, 0),
                new Equipment("Canned Food", 0, 0, 2, 0),
                new Equipment("Helmet", 0, 0, 0, 1),
                new Equipment("Tactical Gloves", 0, 0, 0, 1),
                new Equipment("Light Armor", 0, 0, 0, 1),
                new Equipment("Medium Armor", 0, 0, 0, 2),
                new Equipment("Heavy Armor", 0, 0, 0, 4),
                new Equipment("Riot Shield", 2, 0, 0, 2),
                new Equipment("Medkit", 0, 0, 4, 0),
                new Equipment("RPG", "{a.Name}[{a.Health}] exploded {b.Name}[{b.Health}] using their {eq.Name}.", 7, 0, 0, 0),
                new Equipment("L118A", "{a.Name}[{a.Health}] sniped {b.Name}[{b.Health}] using their {eq.Name}.", 4, 70, 0, 0),
                new Equipment("Barrett 50CAL", "{a.Name}[{a.Health}] sniped {b.Name}[{b.Health}] using their {eq.Name}.", 7, 0, 0, 0),
                new Equipment("Minigun", "{a.Name}[{a.Health}] mowed {b.Name}[{b.Health}] down using their {eq.Name}.", 7, 50, 0, 0),
                new Equipment("AK47", "{a.Name}[{a.Health}] gave {b.Name}[{b.Health}] a few piercings using their {eq.Name}.", 4, 30, 0, 0),
                new Equipment("M16", 4, 15, 0, 0),
                new Equipment("MP9", 3, 15, 0, 0),
                new Equipment("Skorpion", 3, 15, 0, 0),
                new Equipment("Five Seven", 4, 10, 0, 0),
                new Equipment("Scar L", 6, 0, 0, 0),
                new Equipment("Deagle", 5, 5, 0, 0)
            };
        }
    }
}
