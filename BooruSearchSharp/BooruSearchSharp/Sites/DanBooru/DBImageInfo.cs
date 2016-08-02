namespace BooruSearchSharp.DanBooru
{
    /// Contains information of the image post.
    public class DBImageInfo
    {
        /// The id of the image post.
        public int ID { get; set; }
        /// The time at which the post was created.
        public string Created_At { get; set; }
        /// The post uploaders id.
        public int Uploader_ID { get; set; }
        /// The score rating the post is worth.
        public int Score { get; set; }
        /// The source URL the image came from.
        public string Source { get; set; }
        /// The md5 string of the post.
        public string MD5 { get; set; }
        /// The time at which the last comment was bumped.
        public string Last_Comment_BumpedAt { get; set; }
        /// The rating of the image.
        public char Rating { get; set; }
        /// The width of the image in pixels.
        public int Image_Width { get; set; }
        /// The height of the image in pixels.
        public int Image_Height { get; set; }
        /// The various tags associated with the post in a string.
        public string Tag_String { get; set; }
        /// Has the not been locked?
        public bool Is_Note_Locked { get; set; }
        /// The favorites count.
        public int Fav_Count { get; set; }
        /// The ending file extension of the image.
        public string File_Extension { get; set; }
        /// The time at which the post was last noted.
        public string Last_Noted_At { get; set; }
        /// Has the rating of the post been locked?
        public bool Is_Rating_Locked { get; set; }
        /// The parent ID of the post.
        public string Parent_ID { get; set; }
        /// Does the post have any children?
        public bool Has_Children { get; set; }
        /// The ID of the approver of the post.
        public string Approver_ID { get; set; }
        /// The tag count of general tags.
        public int Tag_Count_General { get; set; }
        /// The tag count of artist tags.
        public int Tag_Count_Artist { get; set; }
        /// The tag count of character tags.
        public int Tag_Count_Character { get; set; }
        /// The tag count of copyright notice tags.
        public int Tag_Count_Copyright { get; set; }
        /// The size of the image in bytes.
        public int File_Size { get; set; }
        /// Has the status of the post been locked?
        public bool Is_Status_Locked { get; set; }
        /// The favorites of the post as a string.
        public string Fav_String { get; set; }
        /// The pool string.
        public string Pool_String { get; set; }
        /// The up score of the post.
        public int Up_Score { get; set; }
        /// The down score of the post.
        public int Down_Score { get; set; }
        /// Is the post pending?
        public bool Is_Pending { get; set; }
        /// Has the post been flagged.
        public bool Is_Flagged { get; set; }
        /// Has the post been deleted.
        public bool Is_Deleted { get; set; }
        /// The total number of tags the post has.
        public int Tag_Count { get; set; }
        /// The last time the post was updated.
        public string Updated_At { get; set; }
        /// Has the uploader been banned.
        public bool Is_Banned { get; set; }
        /// The pixiv ID of the post.
        public string Pixiv_ID { get; set; }
        /// The last time the post was commented on.
        public string Last_Commented_At { get; set; }
        /// Does the post have any active children.
        public bool Has_Active_Children { get; set; }
        /// The bit flags of the post.
        public int Bit_Flags { get; set; }
        /// The name of the post uploader.
        public string Uploader_Name { get; set; }
        /// Does the post have a large image?
        public bool Has_Large { get; set; }
        /// The tag of the posts artist.
        public string Tag_String_Artist { get; set; }
        /// The tag of the posts character.
        public string Tag_String_Character { get; set; }
        /// The tag of the post's copyright.
        public string Tag_String_Copyright { get; set; }
        /// The general tags of the post.
        public string Tag_String_General { get; set; }
        /// Does the post have any visible children?
        public bool Has_Visible_Children { get; set; }
        /// The url of the image file.
        public string File_URL { get; set; }
        /// The url of the large image file.
        public string Large_File_URL { get; set; }
        /// The url of the preview image file.
        public string Preview_File_URL { get; set; }
    }
}