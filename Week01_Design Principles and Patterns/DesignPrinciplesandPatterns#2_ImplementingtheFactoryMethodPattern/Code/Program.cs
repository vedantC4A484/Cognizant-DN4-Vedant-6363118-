using FactoryMethodPatternExample;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Factory Method Pattern - Document Management\n");

        DocumentFactory wordFactory = new WordDocumentFactory();
        IDocument wordDoc = wordFactory.CreateDocument();
        wordDoc.Open();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        IDocument pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.Open();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        IDocument excelDoc = excelFactory.CreateDocument();
        excelDoc.Open();

        Console.ReadLine();
    }
}
