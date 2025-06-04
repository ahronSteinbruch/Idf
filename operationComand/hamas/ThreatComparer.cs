using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{

    public class ThreatComparer : IComparer<Terrorist>
    {
        public int Compare(Terrorist x, Terrorist y)
        {
            int result = y.GetThreatLevel().CompareTo(x.GetThreatLevel()); // Descending
            return result != 0 ? result : x.Name.CompareTo(y.Name); // Tie-breaker
        }
    }

}
