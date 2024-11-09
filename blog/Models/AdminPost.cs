using blog.Interfaces;

namespace blog.Models
{
    // AdminPost.cs
    public class AdminPost : IPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        private string ImageUrl { get; set; }

        public string AddImage(string imageUrl)
        {
            ImageUrl = imageUrl;
            return $"Image '{imageUrl}' added to Admin post.";
        }

        public string Publish()
        {
            return $"Admin Post Published: Title: {Title}, Content: {Content}, Image: {ImageUrl}";
        }
    }

}
