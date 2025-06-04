using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class Comander :Soldier
    {
        private List<Soldier> _directSubOrdinatse;
        
        public Comander(long soldierId, string basis, string unit, string name, bool mail, DateTime birthDey, string address):base(soldierId,basis, unit, name, mail, birthDey, address)
        {
            _directSubOrdinatse = new List<Soldier>();
        }
    }
}
