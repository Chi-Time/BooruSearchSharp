namespace BooruSearchSharp
{
    public class DoujinInfo
    {
        /// The category ID of the doujin. Append this to the URL for the doujin webpage.
        public string Category_ID { get; set; }
        /// The title/name of the doujin.
        public string Title { get; set; }
        /// The translation type of the doujin
        public string Translation_Type { get; set; }
        /// The name of the doujin's artist.
        public string Artist { get; set; }
        /// The tags associated with the doujin.
        public string Tags { get; set; }
        /// The rating of the doujin.
        public string Rating { get; set; }
        /// The doujin's score on the site.
        public int Score { get; set; }
        /// The time of the last comment on the doujin.
        public string Last_Comment { get; set; }
        /// The time at which the doujin was uploaded.
        public int Uploaded_By { get; set; }
        /// The file directory of the doujin.
        public string Directory { get; set; }
        /// The file name of the doujin's image.
        public string File_Name { get; set; }
        /// The MD5 string of the doujin.
        public string MD5 { get; set; }
        /// The url to the doujin's cover image.
        public string File_URL { get; set; }
        /// The url to the preview of the doujin's cover image.
        public string Preview_URL { get; set; }
        /// The domain associated with the doujin's image.
        public string Image_Domain { get; set; }
    }
}