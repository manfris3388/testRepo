using baigiamasis_darbas.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baigiamasis_darbas
{
    public class GenerateReport
    {
        private StudentRepo _studentRepo;
        private SubjectRepo _subjectRepo;
        private TrimesterRepo _trimesterRepo;
        public GenerateReport(StudentRepo studentRepo, SubjectRepo subjectRepo, TrimesterRepo trimesterRepo)
        {
            _studentRepo = studentRepo;
            _subjectRepo = subjectRepo;
            _trimesterRepo = trimesterRepo;
        }
        public List<ReportCase> GetReports()
        {
            List<ReportCase> reportCases = new List<ReportCase>();
            var students = _studentRepo.GetStudents();
            foreach (var student in students)
            {
                string studentName = student.Name;
                foreach (int subjectId in student.SubjectIds)
                {
                    Subject subject = _subjectRepo.GetSubject(subjectId);
                    string subjectName = subject.Name;                    
                    foreach (var trimesterHash in subject.TrimesterHash)
                    {            
                        var trimester = _trimesterRepo.GetTrimester(trimesterHash);
                        int trimesterAv = (int) Math.Round(trimester.Marks.Average());
                        reportCases.Add(new ReportCase(studentName, subjectName, trimesterAv, trimester.Marks));
                    }
                }
            }
            return reportCases;
        }
    }
}
