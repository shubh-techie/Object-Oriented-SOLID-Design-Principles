using ShubhDev.Solid.LiskovSubstitutionPrinciple;
using ShubhDev.Solid.OpenClosedPrinciple;
using ShubhDev.Solid.OpenClosedPrinciple.ReportGenerate;
using ShubhDev.Solid.SingleResponsibilityPrinciple;
using ShubhDev.Solid.SingleResponsibilityPrinciple.Email;
using ShubhDev.Solid.SingleResponsibilityPrinciple.Logger;
using System;

namespace ShubhDev.SolidDesignPrinciples
{
    class Program
    {
        static AbsReportGeneration ReportGeneration;
        static void Main(string[] args)
        {
            //TestingOpenClosePrinciple();
            TestingLisKovPrinciple();

            Console.WriteLine("Press <enter> to exit!");
            Console.ReadLine();
        }

        private static void TestingLisKovPrinciple()
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }

        private static void TestingOpenClosePrinciple()
        {
            Employee employee = new Employee() { Employee_Id = 303007, Employee_Name = "S Prabhat" };

            ReportGeneration = new PDFReportGeneration();
            ReportGeneration.ReportGeneration(employee);

            ReportGeneration = new ExcelReportGeneration();
            ReportGeneration.ReportGeneration(employee);

            ReportGeneration = new DocsReportGeneration();
            ReportGeneration.ReportGeneration(employee);

            ReportGeneration = new CRSReportGeneration();
            ReportGeneration.ReportGeneration(employee);
        }
    }
}
