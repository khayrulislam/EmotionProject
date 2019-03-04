using System;
using System.IO;
using System.Net;

namespace EmotionAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {

            string sURL = "http://api.github.com/repos/khayrulislam/WebTechnology/commits";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";
            //request.Credentials = CredentialCache.DefaultCredentials;
            request.UserAgent = "lifehell";
            //request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();


            Console.WriteLine("Hello World!   ");
            Console.ReadLine();
            
        }

        
    }
}
