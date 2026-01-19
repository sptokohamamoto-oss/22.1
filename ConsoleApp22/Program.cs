using System; 
using System.Collections.Generic;


class Report 
{
    public string EmployeeName;
    public int HoursWorked;

    public Report(string employeeName, int hoursWorked)
    {
        EmployeeName = employeeName;
        HoursWorked = hoursWorked;
    }
}
class ReportCalculator
{
    public int CalculateWage(Report report) 
    {
        const int hourlyWage = 1000;
        return report.HoursWorked * hourlyWage;
    }
}
class ReportSaver 
{
    public void Save(Report Report) 
    {
        Console.WriteLine($"保存しました: {Report.EmployeeName},勤務時間: {Report.HoursWorked}");
    }
}