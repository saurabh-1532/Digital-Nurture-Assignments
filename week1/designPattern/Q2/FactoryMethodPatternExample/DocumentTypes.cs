using System;

public interface IDocumentType
{
    void ProcessContent();
    void SaveFile();
}

public class WordDoc : IDocumentType
{
    public void ProcessContent()
    {
        Console.WriteLine("Loading Word text editor...");
    }

    public void SaveFile()
    {
        Console.WriteLine("Document saved as .docx");
    }
}

public class PdfDoc : IDocumentType
{
    public void ProcessContent()
    {
        Console.WriteLine("Loading PDF read-only viewer...");
    }

    public void SaveFile()
    {
        Console.WriteLine("Document saved as .pdf");
    }
}

public class ExcelDoc : IDocumentType
{
    public void ProcessContent()
    {
        Console.WriteLine("Loading spreadsheet grid...");
    }

    public void SaveFile()
    {
        Console.WriteLine("Document saved as .xlsx");
    }
}