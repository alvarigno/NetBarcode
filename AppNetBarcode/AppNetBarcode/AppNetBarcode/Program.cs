using System;
using System.Drawing.Imaging;

namespace AppNetBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.ReadKey();

            var barcode = new Barcode("7359999155288", Type.EAN13, true, 1000, 500);

            barcode.SaveImageFile("./path", ImageFormat.Jpeg);

            var value1 = barcode.GetBase64Image();


            Console.WriteLine(value1);

            Console.WriteLine("Fin App");

        }
    }
}
