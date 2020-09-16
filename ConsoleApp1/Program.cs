using System;
using Google.Cloud.Vision.V1;
using RestSharp;
namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            //                     GOOGLE CLOUD API
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "<location of key.json>");
            var image = Image.FromFile("<location of image file>");
            var client = ImageAnnotatorClient.Create();
            var response = client.DetectDocumentText(image);
            Console.WriteLine(response.Text);


        }
    }
}