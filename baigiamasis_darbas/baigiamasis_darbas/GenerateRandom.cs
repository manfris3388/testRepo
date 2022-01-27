using baigiamasis_darbas.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class GenerateRandom
    {
        Random random = new Random();
        int minCount = 2;
        int maxCount = 5;
        int minScore = 1;
        int maxScore = 10;
        int minSubj = 6;
        int maxSubj = 10;
        SubjectRepo subjectRepo = new SubjectRepo();

        public List<int> GetTrimesterMarks()
        {
            List<int> marks = new List<int>();
            int marksCount = random.Next(minCount, maxCount);
            for(int i = 0; i < marksCount; i++)
            {
                marks.Add(random.Next(minScore, maxScore));
            }
            return marks;
        }
        public List<int> GetSubjectIds()
        {
            List<int> subjectIds = new List<int>();
            int subjcount = random.Next(minSubj, maxSubj);            
            for (int i = 0;i < subjcount;i++)
            {
                int subjectId = random.Next(0, subjectRepo.GetSubjectCount());
                subjectIds.Add(subjectId);
            }
            return subjectIds.Distinct().ToList();
        }
        public HashCode GetTrimesterHash()
        {
            HashCode hashCode = new HashCode();
            return hashCode;
        }
    }
}
