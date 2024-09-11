namespace SingleResponsibilityPrinciple;
using System;
class Program
{
    static void Main(string[] args)
    {
        Report report = new();
        FileManager fileManager = new();
        ReportGenerator reportGenerator = new();
        ReportFormatter reportFormatter= new();
        
        string generatedContent = reportGenerator.GenerateReport("This is some content.");
        report.Content = generatedContent;

        report.Content = reportFormatter.FormatReport(report.Content);
        fileManager.SaveToFile("report.txt", report.Content);

        string loadedContent = fileManager.LoadFromFile("report.txt");
        Console.WriteLine($"Loaded Content: {loadedContent}");
    }
}