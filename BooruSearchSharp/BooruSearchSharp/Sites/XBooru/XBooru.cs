using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Collections.Generic;

namespace BooruSearchSharp
{
    public class XBooru
    {
        public XBooru ()
        {
            Start ();
        }

        void Start ()
        {
            var lstImages = new List<ImageInfo> ();

            Console.WriteLine ("Welcome to xbooru search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();

            var document = new XmlDocument ();
            document.LoadXml (RequestURLData (SearchTags (term)));
            var im = new XBImageInfo (document);

            for (int i = 0; i < im.Posts.Count; i++)
            {
                Console.WriteLine (im.Posts[i].ID);
                Console.WriteLine (im.Posts[i].File_URL);
            }
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
            string url = "http://xbooru.com/index.php?page=dapi&s=post&q=index&{0}{1}";
            string api = "tags=";

            string parsedURL = string.Format (url, api, searchTerm);

            return parsedURL;
        }
    }
}
