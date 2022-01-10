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
        public string Surname { get; set; }
        public int DiaryId { get; set; }

        public Student(int id, string name, string surname, int diaryId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DiaryId = diaryId;
        }
    }
}
