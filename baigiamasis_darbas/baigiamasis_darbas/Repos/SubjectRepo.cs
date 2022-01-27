using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas.Repos
{
    public class SubjectRepo
    {
        int i = 0;
        List<string> subjectsNames = new List<string>() { "Matematika", "Lietuvių kalba", "Anglų kalba", "Fizika", "Kūno kultūra", "Dailė", "Muzika",
            "Vokiečių kalba", "Chemija", "Istorija", "Lotynų kalba", "Etika", "Biologija", "Darbai"};
        List<Subject> subjects = new List<Subject>();
        public SubjectRepo()
        {
            List<int> trimesterIds = new List<int>();
            foreach (string subjectName in subjectsNames)
            {   
                for(int j = 0; j < 3; j++)
                {
                    int trimesterId = i * 3 + j;
                    trimesterIds.Add(trimesterId);
                }
                int id = i;
                subjects.Add(new(id, subjectName));
                i++;
            }
        }
        public List<Subject> GetSubjects()
        {
            return subjects;
        }
        public Subject GetSubject(int id)
        {
            return subjects[id];
        }
        public int GetSubjectCount()
        {
            return subjects.Count;
        }
    }
}




//
//
//trimesterIds.Add(trimesterId);