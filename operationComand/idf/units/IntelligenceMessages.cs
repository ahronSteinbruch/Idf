using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Idf
{
   

    public class IntelligenceMessage
    {
        public int Id { get; set; }
        public List<Terrorist> Targets { get; set; }
        public Goals Location { get; set; } // e.g. "בבית", "ברכב"
        public DateTime ReportTime { get; set; }
        public TimeSpan ValidityDuration { get; set; } = TimeSpan.FromHours(24);
        public IntelSourceType Source { get; set; }
        public int CredibilityScore { get; set; } // 1-100

    public IntelligenceMessage(int id, List<Terrorist> targets, Goals location,DateTime reportTime,
        TimeSpan validityDuration,IntelSourceType source,int credibilityScore)
        {
            Id = id;
            this.Targets = targets;
            Location = location;
            ReportTime = reportTime;
            ValidityDuration = validityDuration;
            Source = source;
            CredibilityScore = credibilityScore;
        }

        public bool IsExpired(DateTime currentTime)
        {
            return currentTime > ReportTime + ValidityDuration;
        }

        public bool IsReliable(int minimumCredibility)
        {
            return CredibilityScore >= minimumCredibility;
        }
    }

}
