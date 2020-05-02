using System;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using AppNetBarcode.PDF;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace AppNetBarcode
{
    class Program
    {


        static string filePath = @$"{(($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/libwkhtmltox.so").Replace(@"\", @"/"))}";

        static void Main(string[] args)
        {

            var converter = new BasicConverter(new PdfTools());


            Console.WriteLine("Hello World!");


            Console.ReadKey();



            var barcode = new Barcode("7359999155288", Type.EAN13, true, 1000, 500);

            barcode.SaveImageFile("./path", ImageFormat.Jpeg);

            var value1 = barcode.GetBase64Image();


            Console.WriteLine(value1);


            ////PDF

            var globalSettings = new GlobalSettings
            {
                ColorMode = DinkToPdf.ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4, 
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                Out = Path.Combine(Directory.GetCurrentDirectory())+"Employee_Report.pdf"
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(value1),
                //WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

//            var uno = converter.Convert(pdf);


            ///FIN PDF




            Console.WriteLine("Fin App");

        }
    }
}
