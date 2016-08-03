using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml;
using System.Net;
using System.Xml.Serialization;

namespace BooruSearchSharp
{
    class Program
    {
        public static void Main (string[] args) => new Program ().Start ();

        void Start ()
        {
            Console.WriteLine ("Program Entered.\n\n\n");
            //var sb = new SearchBooru.SearchBooru ();
            //var db = new DanBooru.DanBooru ();
            //var yd = new Yandere.Yandere ();
            //var kc = new Konachan.Konachan ();
            //var lb = new Lolibooru.Lolibooru ();
            //var dlb = new DelishBooru.DelishBooru ();
            //var e62 = new E621.E621 ();
            //var ub = new UberBooru.UberBooru ();
            //var bb = new BroniBooru ();
            //var td = new TheDoujin ();

            Console.ReadKey ();
        }

        string Shit ()
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create (
              "http://gelbooru.com/index.php?page=dapi&s=post&q=index&tags=vore");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse ();
            // Display the status.
            Console.WriteLine (( (HttpWebResponse)response ).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream ();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader (dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd ();
            // Display the content.
            //Console.WriteLine (responseFromServer);
            // Clean up the streams and the response.
            reader.Close ();
            response.Close ();
            return responseFromServer;
        }
    }
}
