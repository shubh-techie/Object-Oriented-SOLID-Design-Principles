using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.Solid.OpenClosedPrinciple
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
    }

    public enum ReportType
    {
        PDF,
        EXCEL,
        DOCS,
        CRS
    };

    public class ReportGenerationWithoutOpenClose
    {
        public void GenerateReport(Employee employee, ReportType reportType)
        {
            if (reportType == ReportType.CRS)
            {
                //generate crystal report
            }
            if (reportType == ReportType.EXCEL)
            {
                //generate crystal report
            }
            if (reportType == ReportType.DOCS)
            {
                //generate crystal report
            }
            if (reportType == ReportType.PDF)
            {
                //generate crystal report
            }
        }
    }
}
