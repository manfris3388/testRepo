using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Repos
{ 
    public class TrimesterRepo
    {
        public List<Trimester> trimesters = new List<Trimester>();

        public void SetTrimesterList()
        {
            trimesters.Add(new Trimester());
        }

        public List<Trimester> GetTrimesters()
        {
            return trimesters;
        }
        public Trimester GetTrimester(HashCode hash)
        {
            return trimesters.Ha;
        }
    }
}
