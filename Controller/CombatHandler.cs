using BattleRoyale;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class CombatHandler
    {
        public static void XKilledY(Player a, Player b)
        {
            string toPrint;
            Equipment eq = a.BestFightEquipment();

            if (eq.Killmessage.Equals(""))
            {
                toPrint = $"  {a.Name}[{a.Health}] killed {b.Name}[{b.Health}] using their {eq.Name}.";
            } else
            {
                toPrint = "  " + eq.Killmessage.Replace("{a.Name}", a.Name).Replace("{b.Name}", b.Name).Replace("{a.Health}", "" + a.Health).Replace("{b.Health}", "" + b.Health).Replace("{eq.Name}", "" + eq.Name);
            }

            a.Kills++;
            foreach (Equipment e in b.Equipment) {a.Equipment.Add(e);}
            Console.WriteLine(toPrint);
        }

        public static void Fight(Player a, Player b)
        {

            b.Hurt(a.BestFightEquipment().Damage());
            if (b.Health<=0)
            {
                XKilledY(a, b);
            } else
            {
                a.Hurt(b.BestFightEquipment().Damage());
                if (a.Health<=0)
                {
                    XKilledY(b, a);
                } else
                {
                    Console.WriteLine($"  {a.Name}[{a.Health}] and {b.Name}[{b.Health}] fight.");
                }
            }
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
