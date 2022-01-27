using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> SubjectIds { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            SubjectIds = new GenerateRandom().GetSubjectIds();
        }
    }
}
