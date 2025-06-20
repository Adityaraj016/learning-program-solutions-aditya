using System;

public interface IDocument
{
    void Open();
}

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a Word Document.");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening a PDF Document.");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening an Excel Document.");
    }
}

public static class DocumentFactory
{
    public static IDocument CreateDocument(string type)
    {
        return type.ToLower() switch
        {
            "word" => new WordDocument(),
            "pdf" => new PdfDocument(),
            "excel" => new ExcelDocument(),
            _ => throw new ArgumentException("Unknown document type.")
        };
    }
}

class Program
{
    static void Main()
    {
        IDocument doc1 = DocumentFactory.CreateDocument("word");
        doc1.Open();

        IDocument doc2 = DocumentFactory.CreateDocument("pdf");
        doc2.Open();

        IDocument doc3 = DocumentFactory.CreateDocument("excel");
        doc3.Open();
    }
}
