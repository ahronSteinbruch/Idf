using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kodkodIdf.operationComand.helpersClasses.Helpers;
using kodkodIdf.operationComand.helpersClasses.interFace;

namespace kodkodIdf.operationComand.idf.strikeWoeaponsArsenal
{
    internal class Artillery : AttackTool,IfuelSistem
    {
        int fule;
        int FuleCapaciti;
        public Artillery(string name,int restTime,int fuleCapaciti, int ammunitionStrikeCapacity,List<Goals> strikesCapacity, Location location):base(name, ammunitionStrikeCapacity, location, restTime)
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
