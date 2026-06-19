using System;

public abstract class DocumentBuilder
{
    public abstract IDocumentType GenerateDocument();

    public void ExecuteDocumentWorkflow()
    {
        IDocumentType activeDoc = GenerateDocument();
        activeDoc.ProcessContent();
        activeDoc.SaveFile();
    }
}

public class WordBuilder : DocumentBuilder
{
    public override IDocumentType GenerateDocument()
    {
        return new WordDoc();
    }
}

public class PdfBuilder : DocumentBuilder
{
    public override IDocumentType GenerateDocument()
    {
        return new PdfDoc();
    }
}

public class ExcelBuilder : DocumentBuilder
{
    public override IDocumentType GenerateDocument()
    {
        return new ExcelDoc();
    }
}