using System;

namespace BattleRoyale
{
    public class Equipment
    {
        public string Name {get;set;}
        public int Power{get;set;} = 0;
        public int Healing{get;set;} = 0;
        public int CritChance{get;set;} = 0;
        public int Protection{get;set;} = 0;

        public int Damage()
        {
            if (CritChance>0)
            {
                if (new Random().Next(1,100)<CritChance)
                {
                    return Power*2;
                } else
                {
                    return Power;
                }
            } else
            {
                return Power;
            }
        }

        public Equipment(string Name, int Power, int Healing, int CritChance, int Protection)
        {
            this.Name = Name;
            this.Power = Power;
            this.Healing = Healing;
            this.CritChance = CritChance;
            this.Protection = Protection;
        }
    }
}
