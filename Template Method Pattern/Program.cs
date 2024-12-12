namespace Template_Method_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // генерация отчета по студентам
            ReportGenerator studentReport = new StudentReportGenerator();
            studentReport.GenerateReport();

            Console.WriteLine("///////////////////////////////////////////////ОТЧЕТ ПО КУРСАМ ///////////////////////////////////////////////////////"); 

            // Генерация отчета по курсам
            ReportGenerator courseReport = new CourseReportGenerator();
            courseReport.GenerateReport();
        }
    }
}