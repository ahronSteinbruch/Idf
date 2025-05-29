
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Idf
{
    public class IDF
    {
        private static readonly IDF _instance = new IDF();

        public DateTime DateEstablished { get; } = new DateTime(1948, 5, 14);

        public Comander CurrentCommander { get; set; }
       
       
        public StrikeWoeaponsArsenal strikeWoeaponsArsenal;

        private IDF()
        {
            strikeWoeaponsArsenal = new StrikeWoeaponsArsenal();
        }

        public static IDF Instance => _instance;
    }
}
