using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Idf
{
    internal class Operation
    {
        private IntelligenceMessage intelmsg { get; set; }     
        private AttackTool attackTool;
        bool successful;

        public Operation(IntelligenceMessage intelmsg)
        {
            this.intelmsg = intelmsg;
        }

        private void chooseStrikeUnit() 
        {
            
        }

        private void attack()
        {
            this.successful = this.attackTool.strike();
        }
        private void report()
        {

        }

    }
}
