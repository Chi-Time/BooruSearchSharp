using System;
using System.Xml;
using System.Collections.Generic;

namespace BooruSearchSharp.Gel
{
    public class ImageInfo
    {
        public int Count { get; set; }
        public int Offset { get; set; }
        public List<Post> Posts = new List<Post> ();

        public ImageInfo (XmlDocument doc)
        {
            //Console.WriteLine (doc.ChildNodes.Item (1).Name);
            //Console.Write (doc.ChildNodes.Item (1).Attributes.Item (0).Name + "\n");
            //Console.Write (doc.ChildNodes.Item (1).Attributes.Item (0).Value + "\n");
            Count = int.Parse (doc.ChildNodes.Item (1).Attributes.Item (0).Value);
            //Console.Write (doc.ChildNodes.Item (1).Attributes.Item (1).Name + "\n");
            //Console.Write (doc.ChildNodes.Item (1).Attributes.Item (1).Value + "\n");
            Offset = int.Parse (doc.ChildNodes.Item (1).Attributes.Item (1).Value);

            for (int i = 0; i < doc.ChildNodes.Item (1).ChildNodes.Count; i++)
            {
                var post = new Post {
                    Height = int.Parse(doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (0).Value),
                    Score = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (1).Value),
                    File_URL = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (2).Value,
                    Parent_ID = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (3).Value,
                    Sample_URL = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (4).Value,
                    Sample_Width = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (5).Value),
                    Sample_Height = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (6).Value),
                    Preview_URL = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (7).Value,
                    Rating = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (8).Value,
                    Tags = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (9).Value,
                    ID = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (10).Value),
                    Width = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (11).Value),
                    Change = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (12).Value),
                    MD5 = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (13).Value,
                    Creator_ID = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (14).Value),
                    Has_Children = bool.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (15).Value),
                    Created_At = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (16).Value,
                    Status = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (17).Value,
                    Source = doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (18).Value,
                    Has_Notes = bool.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (19).Value),
                    Has_Comments = bool.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (20).Value),
                    Preview_Width = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (21).Value),
                    Preview_Height = int.Parse (doc.ChildNodes.Item (1).ChildNodes.Item (i).Attributes.Item (22).Value),
                };
                Posts.Add (post);
            }
            Console.WriteLine (Posts.Count);
        }
    }

    public class Post
    {
        public int Height { get; set; }
        public int Score { get; set; }
        public string File_URL { get; set; }
        public string Parent_ID { get; set; }
        public string Sample_URL { get; set; }
        public int Sample_Width { get; set; }
        public int Sample_Height { get; set; }
        public string Preview_URL { get; set; }
        public string Rating { get; set; }
        public string Tags { get; set; }
        public int ID { get; set; }
        public int Width { get; set; }
        public int Change { get; set; }
        public string MD5 { get; set; }
        public int Creator_ID { get; set; }
        public bool Has_Children { get; set; }
        public string Created_At { get; set; }
        public string Status { get; set; }
        public string Source { get; set; }
        public bool Has_Notes { get; set; }
        public bool Has_Comments { get; set; }
        public int Preview_Width { get; set; }
        public int Preview_Height { get; set; }
    }
}
