using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    
    public abstract class AttackTool
    {
        
        public string name;
        public int AmmunitionStrikeCapacity;
        public int strikesCapacity;
        public List<Goals> EffectiveGoals;
        public Location location;
        public int restingTime;
        static readonly Random random = new Random();

        public bool strike()
        {
            this.AmmunitionStrikeCapacity--;
            return new Random().Next(3) != 0;
        }
        public void charge(){this.AmmunitionStrikeCapacity = this.strikesCapacity;}

        public AttackTool(string name,int ammunt,List<Goals> effectivTergets,Location location,int restTime)
        {
            this.restingTime = restTime;
            this.name = name;
            this.AmmunitionStrikeCapacity = ammunt;
            this.location = location;
            this.EffectiveGoals = effectivTergets;
        }

    }
}
