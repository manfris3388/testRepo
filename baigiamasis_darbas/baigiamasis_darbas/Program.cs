using baigiamasis_darbas;
using baigiamasis_darbas.Repos;

StudentRepo studentRepo = new StudentRepo();
SubjectRepo subjectRepo = new SubjectRepo();
TrimesterRepo trimesterRepo = new TrimesterRepo();

var generateReport = new GenerateReport(studentRepo,subjectRepo,trimesterRepo);
var report = generateReport.GetReports();
foreach (ReportCase reportCase in report)
{
    Console.WriteLine(reportCase.Name, reportCase.Subject,reportCase.TrimesterScore, reportCase.Marks);
}
