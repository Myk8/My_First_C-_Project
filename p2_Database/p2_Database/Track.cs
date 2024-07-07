namespace p2_Database
{
    internal class Track
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Number { get; set; }

        public required string videoURL { get; set; }
        public required string Lyrics { get; set; }
        public int album_ID { get; set; }
    }
}