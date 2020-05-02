using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using Spire.Pdf;

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


//            byte[] bytes = Convert.FromBase64String(value1);


//System.IO.FileStream stream =
//    new FileStream(Directory.GetCurrentDirectory() + "test.pdf", FileMode.CreateNew);
//            System.IO.BinaryWriter writer =
//                new BinaryWriter(stream);
//            writer.Write(bytes, 0, bytes.Length);
//            writer.Close();



            Console.WriteLine(value1);

            Console.WriteLine("Fin App");

        }
    }
}
