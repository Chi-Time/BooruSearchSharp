using System.Xml;
using System.Collections.Generic;

namespace BooruSearchSharp.FurryBooru
{
    public class FBIMageInfo
    {
        public int Count { get; set; }
        public int Offset { get; set; }
        public List<FBPost> Posts = new List<FBPost> ();
        private XmlDocument _Document;

        public FBIMageInfo (XmlDocument doc)
        {
            _Document = doc;
            GenerateImageInformation ();
            GeneratePostInformation ();
        }

        void GenerateImageInformation ()
        {
            Count = int.Parse (_Document.ChildNodes.Item (1).Attributes.Item (0).Value);
            Offset = int.Parse (_Document.ChildNodes.Item (1).Attributes.Item (1).Value);
        }

        void GeneratePostInformation ()
        {
            for (int i = 0; i < _Document.ChildNodes.Item (1).ChildNodes.Count; i++)
            {
                Posts.Add (CreatePost (i));
            }
        }

        FBPost CreatePost (int iterator)
        {
            return new FBPost {
                Height = int.Parse (GetElement (iterator, 0)),
                Score = int.Parse (GetElement (iterator, 1)),
                File_URL = GetElement (iterator, 2),
                Parent_ID = GetElement (iterator, 3),
                Sample_URL = GetElement (iterator, 4),
                Sample_Width = int.Parse (GetElement (iterator, 5)),
                Sample_Height = int.Parse (GetElement (iterator, 6)),
                Preview_URL = GetElement (iterator, 7),
                Rating = GetElement (iterator, 8),
                Tags = GetElement (iterator, 9),
                ID = int.Parse (GetElement (iterator, 10)),
                Width = int.Parse (GetElement (iterator, 11)),
                Change = int.Parse (GetElement (iterator, 12)),
                MD5 = GetElement (iterator, 13),
                Creator_ID = int.Parse (GetElement (iterator, 14)),
                Has_Children = bool.Parse (GetElement (iterator, 15)),
                Created_At = GetElement (iterator, 16),
                Status = GetElement (iterator, 17),
                Source = GetElement (iterator, 18),
                Has_Notes = bool.Parse (GetElement (iterator, 19)),
                Has_Comments = bool.Parse (GetElement (iterator, 20)),
                Preview_Width = int.Parse (GetElement (iterator, 21)),
                Preview_Height = int.Parse (GetElement (iterator, 22)),
            };
        }

        string GetElement (int childPosition, int elementID)
        {
            return _Document.ChildNodes.Item (1).ChildNodes.Item (childPosition).Attributes.Item (elementID).Value;
        }
    }
}
