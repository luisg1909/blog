using blog.Interfaces;

namespace blog.Models
{
    // RegularUserPost.cs
    public class RegularUserPost : IPost
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public string AddImage(string imageUrl)
        {
            return "Regular users cannot add images.";
        }

        public string Publish()
        {
            return $"Regular User Post Published: Title: {Title}, Content: {Content}";
        }
    }

}
