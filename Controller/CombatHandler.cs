using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CombatHandler
    {
        public static void Fight(Player a, Player b)
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

        public static void Ambush(Player a, Player b)
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
    }
}
