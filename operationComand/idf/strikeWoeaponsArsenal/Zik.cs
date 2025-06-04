using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    internal class Zik : AttackTool
    {
        public Zik(string name,Soldier maphil, int ammunt, List<Goals> effectivTergets, Location location, int restTime) :base(name,ammunt,effectivTergets,location,restTime)
        {
            this.name = name;
            this.AmmunitionStrikeCapacity = ammunt;
            this.EffectiveGoals = new List<Goals> {Goals.People, Goals.Vehicles};
            this.location = location;
        }
    }
}
