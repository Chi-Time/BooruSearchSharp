using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BooruSearchSharp.Yandere
{
    public class Yandere
    {
        public Yandere ()
        {
            Start ();
        }

        void Start ()
        {
            Console.WriteLine ("Welcome to Yande.re image search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();

            string objectData = RequestURL (Search (term));

            //Console.WriteLine (objectData);
            //Console.ReadKey ();

            List<YDImageInfo> imLst = JsonConvert.DeserializeObject<List<YDImageInfo>> (objectData);

            for (int i = 0; i < imLst.Count; i++)
            {
                Console.WriteLine (imLst[i].ID+"\n");
                Console.WriteLine (imLst[i].File_URL+"\n\n");
            }
        }

        string RequestURL (string urlRequest)
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

        string Search (string searchTerm)
        {
            string url = "https://yande.re/";
            string api = "post.json?tags={0}";

            string parsedURL = string.Format (url + api, searchTerm);

            return parsedURL;
        }
    }
}
