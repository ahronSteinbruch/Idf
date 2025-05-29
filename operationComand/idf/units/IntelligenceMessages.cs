using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kodkodIdf.operationComand.helpersClasses;
using kodkodIdf.operationComand.hamas;


namespace kodkodIdf.operationComand.idf.units
{
   

    public class IntelligenceMessage
    {
        public int Id { get; set; }
        public Terrorist Target { get; set; }
        public Goals Location { get; set; } // e.g. "בבית", "ברכב"
        public DateTime ReportTime { get; set; }
        public TimeSpan ValidityDuration { get; set; } = TimeSpan.FromHours(24);
        public IntelSourceType Source { get; set; }
        public int CredibilityScore { get; set; } // 1-100

        public bool IsExpired(DateTime currentTime)
        {
            return currentTime > ReportTime + ValidityDuration;
        }

        public bool IsReliable(int minimumCredibility)
        {
            return CredibilityScore >= minimumCredibility;
        }

        public override string ToString()
        {
            return $"דיווח על {Target?.Name} במיקום {Location} בשעה {ReportTime}, מקור: {Source}, אמינות: {CredibilityScore}";
        }
    }

}
