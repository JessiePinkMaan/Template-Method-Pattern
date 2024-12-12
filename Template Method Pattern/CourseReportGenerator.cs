using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class CourseReportGenerator : ReportGenerator
    {
        protected override void StudentData()
        {
            Console.WriteLine("данные о курсах");
        }

        protected override void Proces()
        {
            Console.WriteLine("обработка информации о курсах");
        }

        protected override void ReportGEn()
        {
            Console.WriteLine("создание отчета ");
        }
    }
}
