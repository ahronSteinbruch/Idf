using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Idf
{
    internal class Artillery : AttackTool,IfuelSistem
    {
        int fule;
        int FuleCapaciti;
        public Artillery(string name,int restTime,int fuleCapaciti, int ammunitionStrike,
            int Capacity,List<Goals> strikesCapacity, Location location):
            base(name, ammunitionStrike, strikesCapacity, location, restTime)
        {
           this.fule = fuleCapaciti;
            this.FuleCapaciti = fuleCapaciti;
        }

        public void Refueling()
        {
            this.fule += fule;
        }

        int IfuelSistem.GetFuelQuantity()
        {
            return fule;
        }

        
    }
}
