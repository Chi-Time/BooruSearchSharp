using System;
using System.IO;
using System.Net;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BooruSearchSharp.Gel
{
    public class GelBooru
    {
        public GelBooru ()
        {
            Start ();
        }

        void Start ()
        {
            var lstImages = new List<ImageInfo> ();
            
            Console.WriteLine ("Welcome to Gelbooru search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();

            var document = new XmlDocument ();
            document.LoadXml (RequestURLData (SearchTags (term)));
            Console.WriteLine (SearchTags (term));
            Console.ReadKey ();
            var im = new ImageInfo (document);
            Console.WriteLine (im.Posts[0].ID);
            Console.WriteLine (im.Posts[0].File_URL);
            //Console.WriteLine (document.ChildNodes.Item (1).Name);
            //string json = JsonConvert.SerializeXmlNode (document.ChildNodes.Item (1), Newtonsoft.Json.Formatting.Indented);
            //string word = "";
            //using (StreamWriter sw = File.CreateText ("gel.json"))
            //{
            //    sw.Write (json);
            //}
            //Console.WriteLine (word);
            //Console.ReadKey ();
            //var im = JsonConvert.DeserializeObject<ImageInfo> (json);
            //Console.WriteLine (im.Posts.Count);
            //Console.WriteLine (document.ChildNodes.Item (1).Attributes.Item (0).Value);
        }

        string RequestURLData (string urlRequest)
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create (urlRequest);
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
            // Clean up the streams and the response.
            reader.Close ();
            response.Close ();
            // Return the content.
            return responseFromServer;
        }

        string SearchTags (string searchTerm)
        {
            string url = "http://gelbooru.com/index.php?page=dapi&s=post&q=index&{0}{1}";
            string api = "tags=";

            string parsedURL = string.Format (url, api, searchTerm);

            return parsedURL;
        }
    }
}
