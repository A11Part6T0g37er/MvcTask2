using System;


namespace Domain
{

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public DateTime Time { get; set; }
    }
}
