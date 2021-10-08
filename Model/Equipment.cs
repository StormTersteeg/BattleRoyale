using System;

namespace BattleRoyale
{
    public class Equipment
    {
        public string Name {get;set;}
        public string Killmessage {get;set;}
        public int Power{get;set;} = 0;
        public int CritChance{get;set;} = 0;
        public int Healing{get;set;} = 0;
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

        public Equipment(string Name, string Killmessage, int Power, int CritChance, int Healing, int Protection)
        {
            this.Name = Name;
            this.Killmessage = Killmessage;
            this.Power = Power;
            this.CritChance = CritChance;
            this.Healing = Healing;
            this.Protection = Protection;
        }

        public Equipment(string Name, int Power, int CritChance, int Healing, int Protection) : this(Name, "", Power, CritChance, Healing, Protection){}
    }
}
