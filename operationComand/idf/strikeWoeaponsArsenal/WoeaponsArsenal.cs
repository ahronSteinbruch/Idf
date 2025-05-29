using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kodkodIdf.operationComand.idf.strikeWoeaponsArsenal
{
    internal class WoeaponsArsenal
    {
        private Dictionary<Goals, List<AttackTool>> ataackUnits = new Dictionary<Goals,List<AttackTool>>();

        public void AddTool(AttackTool attackTool)
        {
            foreach(Goals goel in attackTool.EffectiveGoals) 
            {
                ataackUnits[goel].Add(attackTool);
            }
        }
        public void RemoveTool(AttackTool attackTool)
        {
            foreach (Goals goel in attackTool.EffectiveGoals)
            {
                ataackUnits[goel].Remove(attackTool);
            }
        }
        public Task Rest(AttackTool tool)
        {
            RemoveTool(tool);
            Task.Delay(TimeSpan.FromMinutes(tool.restingTime)); 
            AddTool(tool);
            return Task.CompletedTask;
        }

    }
}
