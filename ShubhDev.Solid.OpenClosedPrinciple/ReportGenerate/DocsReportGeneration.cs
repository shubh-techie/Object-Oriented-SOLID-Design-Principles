using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.OpenClosedPrinciple.ReportGenerate
{
    public class DocsReportGeneration : AbsReportGeneration
    {
        public override void ReportGeneration(Employee employee)
        {
            Console.WriteLine("CRSReportGeneration : ID: {0}, Name:{1}", employee.Employee_Id, employee.Employee_Name);
        }
    }
}
