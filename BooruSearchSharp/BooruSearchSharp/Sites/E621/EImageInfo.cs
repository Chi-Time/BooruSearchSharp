namespace BooruSearchSharp.E621
{
    public class EImageInfo
    {
        public int ID { get; set; }
        public string Tags { get; set; }
        public string Created_At { get; set; }
        public int Creator_ID { get; set; }
        public string Author { get; set; }
        public int Change { get; set; }
        public string Source { get; set; }
        public int Score { get; set; }
        public string MD5 { get; set; }
        public int File_Size { get; set; }
        public string File_URL { get; set; }
        public bool Is_Shown_In_Index { get; set; }
        public string Preview_URL { get; set; }
        public int Preview_Width { get; set; }
        public int Preview_Height { get; set; }
        public int Actual_Preview_Width { get; set; }
        public int Actual_Preview_Height { get; set; }
        public string Sample_URL { get; set; }
        public int SampleWidth { get; set; }
        public int Sample_Height { get; set; }
        public int Sample_File_Size { get; set; }
        public string JPEG_URL { get; set; }
        public int Jpeg_Width { get; set; }
        public int Jpeg_Height { get; set; }
        public int Jpeg_File_Size { get; set; }
        public char Rating { get; set; }
        public bool Has_Children { get; set; }
        public string Parent_ID { get; set; }
        public string Status { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Is_Held { get; set; }
        public string Frames_Pending_String { get; set; }
        public string[] Frames_Pending { get; set; }
        public string Frames_String { get; set; }
        public string[] Frames { get; set; }
    }
}