using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{
    public class Aman
    {
        public List<IntelligenceMessage> intelligenceMessages = new List<IntelligenceMessage>();
        private List<Report> reportes = new List<Report>();
        Hamas hamas = new Hamas("The name of the wicked will rot.");
        
        public void AddNewIntelMsg(IntelligenceMessage newIntelMsg)
        {
            intelligenceMessages.Add(newIntelMsg);
        }

        public void AddReport(Report report)
        {
            reportes.Add(report);
        }

        public Terrorist HighestWantedTerrorist()
        {
            return hamas.getAllTerrorist().GetMostDangerous();
        }

    }
}
