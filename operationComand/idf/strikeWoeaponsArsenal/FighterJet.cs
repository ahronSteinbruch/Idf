using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kodkodIdf.operationComand.helpersClasses.abstracts;
using kodkodIdf.operationComand.helpersClasses.interFace;
using kodkodIdf.operationComand.Enums;

namespace kodkodIdf.operationComand.idf.strikeWoeaponsArsenal
{
    internal class FighterJet : AttackTool,IfuelSistem  
    {
        int fule;
        int FuleCapaciti;
        Soldier pylot;
        public FighterJet(string name, Soldier pylot, int restTime, int fuleCapaciti, int ammunitionStrikeCapacity, List<Goals> strikesCapacity, Location location) : base(name, ammunitionStrikeCapacity, location, restTime)
        {
            this.fule = fuleCapaciti;
            this.FuleCapaciti = fuleCapaciti;
        }

        public int GetFuelQuantity()
        {
            return fule;
        }

        public void Refueling()
        {
            Console.WriteLine("Refueling the fighter jet...");
            fule = FuleCapaciti;
            Console.WriteLine("The fuel tank is full.");
        }
    }
}
