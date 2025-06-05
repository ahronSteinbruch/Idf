using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class Report
    {
        string officerName;
        string targerName;
        bool successfulOperation;
        int reminingAmmo;

        public Report(string officerName, string targerName,bool successes,int reminingAmmo)
        {
            this.officerName = officerName;
            this.targerName = targerName;
            this.successfulOperation = successes;
            this.reminingAmmo = reminingAmmo;
        }


    }
}
