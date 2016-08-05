using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Xml;
using System.Net;
using System.Xml.Serialization;
using BooruSearchSharp.Gel;
using BooruSearchSharp.Safebooru;

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
            //var gel = new GelBooru ();
            var safe = new SafeBooru ();
            Console.ReadKey ();

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml (Shit ());
            //Console.WriteLine (doc.ChildNodes.Item (1).Name);
            //for (int i = 0; i < doc.ChildNodes.Item (1).ChildNodes.Count; i++)
            //{
            //    for (int j = 0; j < doc.ChildNodes.Item (1).ChildNodes.Item (j).Attributes.Count; j++)
            //    {
            //        Console.WriteLine (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (j).Name);
            //    }
            //}
            Console.ReadKey ();

            //string json = JsonConvert.SerializeXmlNode (doc,Newtonsoft.Json.Formatting.Indented,true);
            //Console.WriteLine (json);
            //Console.ReadKey ();

            //var im = JsonConvert.DeserializeObject<BooruSearchSharp.Gel.ImageInfo> (json);
            //Console.WriteLine (im.Count);
            //Console.ReadKey ();

            //XmlSerializer s = new XmlSerializer ((typeof (BooruSearchSharp.Gel.ImageInfo)));
            //StringReader sreader = new StringReader (Shit ());

            //var p = (BooruSearchSharp.Gel.ImageInfo)s.Deserialize (sreader);
            //Console.WriteLine (p.Count);

            Console.ReadKey ();
        }

        string Shit ()
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create (
              "http://gelbooru.com/index.php?page=dapi&s=post&q=index&tags=hair");
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
