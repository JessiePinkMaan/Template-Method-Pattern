using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    class StudentReportGenerator : ReportGenerator
    {
        protected override void StudentData() //данные о студентах
        {
            Console.WriteLine("Собраны данные о студентах");
        }

        protected override void Proces()// обработка
        {
            Console.WriteLine("Обработка cстуденьтиков ");
        }

        protected override void ReportGEn()//отчетность 
        {
            Console.WriteLine("создание отчета ");
        }
    }
}
