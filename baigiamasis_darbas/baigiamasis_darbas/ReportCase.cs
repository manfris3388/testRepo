using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class ReportCase
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int TrimesterScore { get; set; }
        public List<int> Marks { get; set; }
                
        public ReportCase(string name, string subject, int trimesterScore, List<int> marks)
        {
            Name = name;
            Subject = subject;
            TrimesterScore = trimesterScore;
            Marks = marks;
        }
    }
}
