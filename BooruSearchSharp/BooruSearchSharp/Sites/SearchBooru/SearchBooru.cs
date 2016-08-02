using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace BooruSearchSharp.SearchBooru
{
    public class SearchBooru
    {
        public SearchBooru ()
        {
            Start ();
        }

        void Start ()
        {
            Console.WriteLine ("Welcome to SearchBooru image search!\nPlease type the search term. (Leave empty if not wanted.)");
            string term = Console.ReadLine ();
            Console.WriteLine ("Please type the tags. (Leave empty if not wanted.)");
            string tag = Console.ReadLine ();
            Console.WriteLine ("Please type the site. (Leave empty if not wanted.)");
            string site = Console.ReadLine ();
            Console.WriteLine ("Please type the extension. (Leave empty if not wanted.)");
            string extension = Console.ReadLine ();
            Console.WriteLine ("Please type the rating. (Leave empty if not wanted.)");
            string rating = Console.ReadLine ();

            //string objectData = DownloadURL (Search (term, tag, site, extension, rating));
            string objectData = RequestURL (Search (term, tag, site, extension, rating));

            //Console.WriteLine (objectData);
            //Console.ReadKey ();

            SBImageInfo im = JsonConvert.DeserializeObject<SBImageInfo> (objectData);

            for (int i = 0; i < im.Results.Count; i++)
            {
                Console.WriteLine (im.Results[i].Tags+"\n");
                Console.WriteLine (im.Results[i].URL);
            }
        }

        string DownloadURL (string urlRequest)
        {
            var address = new Uri (urlRequest);
            var client = new WebClient ();
            return client.DownloadString (address);
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

        string Search (string searchTerm = "", string tags = "", string site = "", string extension = "", string rating = "s")
        {
            string url = "https://cure.ninja/booru/api/json/?q={0}{1}{2}{3}&f={4}&o=r";

            string term = "";
            string tagA = "";
            string siteA = "";
            string extensionA = "";
            string ratingA = "";

            if (searchTerm != "")
                term = searchTerm;

            if (tags != "")
                tagA = "+tags:" + tags;

            if (site != "")
                siteA = "+url:" + site;

            if (extension != "")
                extensionA = "+url:" + extension;

            if (rating != "")
                ratingA = rating;

            return string.Format (url, term, tagA, siteA, extensionA, ratingA);
        }
    }
}
