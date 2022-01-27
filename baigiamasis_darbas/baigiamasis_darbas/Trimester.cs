using baigiamasis_darbas.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class Trimester
    {
        public HashCode Hash { get; set; }
        public List<int> Marks { get; set; }
        public Trimester()
        {
            Marks = new List<int>();
            GenerateRandom generateRandom = new GenerateRandom();
            Marks = generateRandom.GetTrimesterMarks();
            TrimesterRepo trimesterRepo = new TrimesterRepo();
        }
    }
}
