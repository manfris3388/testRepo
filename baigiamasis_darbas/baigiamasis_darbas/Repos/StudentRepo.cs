using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class StudentRepo
    {
        List<Student> students = new List<Student>();
        GenerateRandom generateRandom = new GenerateRandom();
        public StudentRepo()
        {
            students.Add(new Student(01, "Andrius Anužis"));
            students.Add(new Student(02, "Benas Betmanas"));
            students.Add(new Student(03, "Cicilija Cikovska"));
            students.Add(new Student(04, "Dainius Daunoravičius"));
            students.Add(new Student(05, "Egidijus Eišiškis"));
            students.Add(new Student(06, "Jonas Jonaitis"));
            students.Add(new Student(07, "Petras Petraitis"));
            students.Add(new Student(08, "Kostas Smoriginas"));
            students.Add(new Student(09, "Laura Aušraitė"));
            students.Add(new Student(010, "Miglė Aukštikalnytė"));
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudent(int id)
        {
            return students[id];
        }
    }
}
