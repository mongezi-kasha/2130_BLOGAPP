namespace _2130_BLOGAPP.Models.Domain
{
    public class BlogPost
    {
        public Guid Id{ get; set; }
        public string Title { get; set; }
        public string shortDescription { get; set; }
        public string Content {  get; set; }
        public string FeatureUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }
    }
}
