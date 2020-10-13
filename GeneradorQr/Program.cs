using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System;
using System.IO;

namespace GeneradorQr
{
    class Program
    {
        static void Main(string[] args)
        { 
            Document doc = new Document(PageSize.LETTER);

            //Hacer una app de escritorio.

            PdfWriter.GetInstance(doc, new FileStream(@"E:\prueba.pdf", FileMode.Create));
            doc.Open();

            BarcodeQRCode barCode = new BarcodeQRCode("http://wwww.google.com", 200, 200,null);
            Image codeQRImage = barCode.GetImage();

            doc.Add(codeQRImage);
            doc.Close();
        }
    }
}
