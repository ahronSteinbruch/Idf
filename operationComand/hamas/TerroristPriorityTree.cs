using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodkodIdf.operationComand.hamas
{

    public class TerroristPriorityTree
    {
        long id = 0;
        private SortedSet<Terrorist> _tree;

        public TerroristPriorityTree()
        {
            _tree = new SortedSet<Terrorist>(new ThreatComparer());
        }

        public void Add(Terrorist terrorist)
        {
            _tree.Add(terrorist);
            terrorist.setId();
           
        }

        public void Remove(Terrorist terrorist)
        {
            _tree.Remove(terrorist);
        }

        public void Promote(Terrorist terrorist, int newRank)
        {
            if (_tree.Remove(terrorist))
            {
                terrorist.RankLevel = newRank;
                _tree.Add(terrorist);
            }
        }

        public Terrorist GetMostDangerous()
        {
            return _tree.Count > 0 ? _tree.Min : null;
        }

        public IEnumerable<Terrorist> GetAllOrdered()
        {
            return _tree;
        }
        
        public void PrintAll()
        {
            Console.WriteLine("Terrorist List (Most Dangerous First):");
            foreach (var t in _tree)
                Console.WriteLine($" - {t}");
        }

        public Terrorist FindByName(string name)
        {
            return _tree.FirstOrDefault(t => t.Name == name);
        }

    }

}
