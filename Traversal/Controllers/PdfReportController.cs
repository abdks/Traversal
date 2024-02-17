using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreport/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal");
            document.Add(paragraph);
            document.Close();
             return File("/pdfreport/dosya1.pdf","application/pdf","dosya1.pdf");
        }
        public IActionResult StaticPdfReport2() 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreport/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir Tc");

            pdfPTable.AddCell("Eylül ");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("12143232132");


            pdfPTable.AddCell("Mehmet");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("Misafir Tc");

            document.Add(pdfPTable);

            Paragraph paragraph = new Paragraph("Traversal");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreport/dosya1.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
