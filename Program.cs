using System;
using System.Drawing;
using System.Net;
using ZXing;

namespace QRCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            const string imageUrl = "https://httpsimage.com/v2/c890b3a2-098b-41ab-bb9a-cc727bfc1a95.png";
            // Install-Package ZXing.Net -Version 0.16.5
            var client = new WebClient();
            var stream = client.OpenRead(imageUrl);
            if (stream == null) return;
            var bitmap = new Bitmap(stream);
            IBarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            Console.WriteLine(result.Text);
        }
    }
}
