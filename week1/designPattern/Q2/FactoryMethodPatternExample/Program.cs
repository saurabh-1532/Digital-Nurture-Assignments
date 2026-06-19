using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Testing Word Factory ---");
        DocumentBuilder wordSystem = new WordBuilder();
        wordSystem.ExecuteDocumentWorkflow();

        Console.WriteLine("\n--- Testing PDF Factory ---");
        DocumentBuilder pdfSystem = new PdfBuilder();
        pdfSystem.ExecuteDocumentWorkflow();

        Console.WriteLine("\n--- Testing Excel Factory ---");
        DocumentBuilder excelSystem = new ExcelBuilder();
        excelSystem.ExecuteDocumentWorkflow();
    }
}
