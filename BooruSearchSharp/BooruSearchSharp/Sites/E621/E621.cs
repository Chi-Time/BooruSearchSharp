using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BooruSearchSharp.E621
{
    public class E621
    {
        public E621 ()
        {
            Start ();
        }

        void Start ()
        {
            Console.WriteLine ("Welcome to E621 image search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();

            string objectData = RequestURL (Search (term));

            Console.WriteLine (objectData);
            Console.ReadKey ();

            List<EImageInfo> imLst = JsonConvert.DeserializeObject<List<EImageInfo>> (objectData);

            for (int i = 0; i < imLst.Count; i++)
            {
                Console.WriteLine (imLst[i].ID + "\n");
                Console.WriteLine (imLst[i].File_URL + "\n\n");
            }
        }

        string RequestURL (string urlRequest)
        {
            //WebClient client = new WebClient ();
            //client.Headers.Add ("BooruSearchSharp/1.0 (by username)", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //// Create a request for the URL. 
            //WebRequest request = WebRequest.Create (urlRequest);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create (urlRequest);
            myHttpWebRequest.UserAgent = "BooruSearchSharp/0.1.4 (by username on e621)";
            // If required by the server, set the credentials.
            //request.Credentials = CredentialCache.DefaultCredentials;
            myHttpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            //WebResponse response = request.GetResponse ();
            WebResponse response = myHttpWebRequest.GetResponse ();
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

        string Search (string searchTerm)
        {
            string url = "https://e621.net/post/";
            string api = "index.json?tags={0}";

            string parsedURL = string.Format (url + api, searchTerm);

            return parsedURL;
        }
    }
}
