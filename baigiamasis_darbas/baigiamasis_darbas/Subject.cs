using baigiamasis_darbas.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashCode[] TrimesterHash { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
            GenerateRandom generateRandom = new GenerateRandom();
            TrimesterHash = new HashCode[] { generateRandom.GetTrimesterHash(), generateRandom.GetTrimesterHash(), generateRandom.GetTrimesterHash() }; 
            Trimester trimester = new Trimester();
            foreach(var trimesterHash in TrimesterHash)
            {
                trimester.Hash = trimesterHash;
            }
        }
    }
}
