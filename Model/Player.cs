using BattleRoyale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public string Name {get;set;}
        public List<Equipment> Equipment {get;set;}
        public int Health {get;set;} = 10;
        public int Kills {get;set;} = 0;
        private int uuid = new Random().Next(100000000, 999999999);

        public Player(string Name, List<Equipment> Equipment)
        {
            this.Name = Name;
            this.Equipment = Equipment;
        }

        public Equipment BestFightEquipment()
        {
            int best = -1;
            int i = 0;
            foreach (Equipment piece in Equipment)
            {
                if (best==-1)
                {
                    best = i;
                }
                else if (piece.Power>Equipment[best].Power)
                {
                    best = i;
                }
                i++;
            }

            if (best==-1 || Equipment[best].Power==0)
            {
                return new Equipment("fists", 1, 0, 0, 0);
            } else
            {
                return Equipment[best];
            }
        }

        public Equipment BestConsumableEquipment()
        {
            int best = -1;
            int i = 0;
            foreach (Equipment piece in Equipment)
            {
                if (piece.Healing>0)
                {
                    if (best==-1)
                    {
                        best = i;

                    } else if (piece.Healing>Equipment[best].Healing)
                    {
                        best = i;
                    }
                }
                i++;
            }

            if (best==-1)
            {
                return null;
            } else
            {
                return Equipment[best];
            }
        }

        public void Hurt(int damage)
        {
            int armor = 0;
            foreach (Equipment e in Equipment) {armor = armor + e.Protection;}
            damage = damage - armor;
            if (damage<=0) {damage = 1;}
            Health = Health - damage;
        }

        public bool Equals(Player other_player)
        {
            if (this.uuid==other_player.uuid)
            {
                return true;
            }
            return false;
        }

        public void Rest()
        {
            if (Health<10)
            {
                if (BestConsumableEquipment()!=null)
                {
                    Health = Health + BestConsumableEquipment().Healing;
                    if (Health>10) {Health = 10;}
                    Console.WriteLine($"  {Name}[{Health}] used {BestConsumableEquipment().Name} to heal({BestConsumableEquipment().Healing}).");
                    Equipment.Remove(BestConsumableEquipment());
                } else
                {
                    if (Health<10) {Health++;}
                    Console.WriteLine($"  {Name}[{Health}] took a rest.");
                }
            } else
            {
                if (Health<10) {
                    Health++;
                    Console.WriteLine($"  {Name}[{Health}] took a rest.");
                } else
                {
                    Console.WriteLine($"  {Name}[{Health}] is roaming.");
                }
            }
        }

        public void showEquipment()
        {
            Equipment = Equipment.OrderBy(o=>o.Name).ToList();
            Equipment.Reverse();
            Console.WriteLine(String.Format("  {0,-17} {1,-17} {2,-17} {3,-17} {4,-17}", "Equipment", "Power", "CritChance", "Healing", "Protection"));
            foreach (Equipment e in Equipment)
            {
                Console.WriteLine(String.Format("  {0,-17} {1,-17} {2,-17} {3,-17} {4,-17}", e.Name, e.Power, e.CritChance, e.Healing, e.Protection));
            }
        }
    }
}
