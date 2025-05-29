using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodkodIdf.operationComand.helpersClasses.abstracts
{
    public abstract class Soldier :Person
    {
        private long _SoldierId;
        private string _unit;
        private string _base;
        public Soldier(long soldierId,string basis, string unit, string name, bool isMail, DateTime birthDey, string address):base( name,  isMail,  birthDey, address)
        {
            _SoldierId = soldierId;
            _unit = unit;
            string _base = basis;
        }
    }
}
