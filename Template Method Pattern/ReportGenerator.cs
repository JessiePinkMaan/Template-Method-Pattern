using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern
{
    abstract class ReportGenerator
    {
        // Шаблонный метод 
        public void GenerateReport()
        {
            StudentData();
            Proces();
            ReportGEn();
            ExportReport();
        }

         
        protected abstract void StudentData();
        protected abstract void Proces();
        protected abstract void ReportGEn();

       
        private void ExportReport()
        {
            Console.WriteLine("Отчет ушел");
        }
    }

}
