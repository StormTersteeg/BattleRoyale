using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale
{
    public class Loottable
    {
        public List<Equipment> Loot {get;set;}

        public Loottable(List<Equipment> Loot)
        {
            this.Loot = Loot;
        }

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
    }
}
