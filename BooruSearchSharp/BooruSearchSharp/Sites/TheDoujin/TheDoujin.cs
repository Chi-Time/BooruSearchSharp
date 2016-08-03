using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BooruSearchSharp
{
    public class TheDoujin
    {
        public TheDoujin ()
        {
            Start ();
        }

        void Start ()
        {
            Console.WriteLine ("Welcome to thedoujin doujin search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();

            string objectData = RequestURL (Search (term));

            //Console.WriteLine (objectData);
            //Console.ReadKey ();

            List<DoujinInfo> imLst = JsonConvert.DeserializeObject<List<DoujinInfo>> (objectData);

            for (int i = 0; i < imLst.Count; i++)
            {
                Console.WriteLine ( "http://thedoujin.com/index.php/categories/" + imLst[i].Category_ID + "\n");
                Console.WriteLine (imLst[i].Title + "\n");
                Console.WriteLine (imLst[i].File_URL + "\n\n");
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
            string url = "http://thedoujin.com/index.php/api/categories/";
            string api = "json?tags={0}";

            string parsedURL = string.Format (url + api, searchTerm);

            return parsedURL;
        }
    }
}
