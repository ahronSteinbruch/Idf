using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class Terrorist : Person
    {
        public static long uniqIdGeneretor;
        private long id = 0;
        public string Name { get; }
        public int RankLevel { get; set; }
        public bool isLive;
        public List<WeaponType> Weapons { get; }


        public Location currLocation { get; set; }

        public Terrorist(string name, int rankLevel, List<WeaponType> weapons,bool isLive,bool isMale
            ,string address,DateTime birthDey) :base(name,isMale,birthDey,address)
        {
            Name = name;
            RankLevel = rankLevel;
            Weapons = weapons;
            this.isLive = isLive;
            
        }
        public void setId() { if (id == 0) id = uniqIdGeneretor++;}
        public Location getTerroristLocation()
        {
            return this.currLocation;
        }

        public void setLocation(Location location)
        {
            this.currLocation = location;
        }
        public int GetThreatLevel() => RankLevel * Weapons.Sum(w => (int)w);

        public override string ToString() =>
            $"{Name} | Rank: {RankLevel} | Threat: {GetThreatLevel()}";

        public override int GetHashCode() => Name.GetHashCode();
        public override bool Equals(object obj) => obj is Terrorist other && Name == other.Name;
    }

}
