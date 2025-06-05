using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{

    internal class Hamas
    {
        public DateTime DateEstablished = new DateTime(1987, 10, 12);
        private TerroristPriorityTree terroristsMembers;
        private string correntComander { get; set; }
        public Hamas(string correntComanderName)
        {
            terroristsMembers = new TerroristPriorityTree();
            this.correntComander = correntComander;
        }

        public Terrorist getTerrorist(string name)
        {
            Terrorist terrorist = terroristsMembers.FindByName(name);
            if (terrorist == null)Console.WriteLine($"terrorist {name} not found");
            return terrorist;
        }

        public void addTerrorist(string name, int rankLevel, List<WeaponType> weapons, bool isLive, bool isMeil, string address, DateTime birthDey)
        {
            if (terroristsMembers.FindByName(name) == null) return;
            this.terroristsMembers.Add(new Terrorist(name, rankLevel, weapons, isLive, isMeil, address, birthDey));
        }

        public void removeTerrorist(string name)
        {
            this.terroristsMembers.Remove(getTerrorist(name));
        }
        public TerroristPriorityTree getAllTerrorist()
        {
            return terroristsMembers;
        }

    }


}
