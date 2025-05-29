using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodkodIdf.operationComand.idf.strikeWoeaponsArsenal
{
    internal class Zik : AttackTool
    {
        public Zik(string name, int ammunt, List<Goals> effectivTergets, Location location, int restTime) :base(name,ammunt,effectivTergets,location,restTime)
        {
            this.name = name;
            this.AmmunitionStrikeCapacity = ammunitionStrikeCapacity;
            this.EffectiveGoals = new List<Goals> {Goals.People, Goals.Vehicles};
            this.location = new Location(location);
        }
    }
}
