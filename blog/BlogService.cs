using blog.Interfaces;

namespace blog
{
    // BlogService.cs
    public class BlogService
    {
        private IBlogFactory _blogFactory;

        public BlogService(IBlogFactory blogFactory)
        {
            _blogFactory = blogFactory;
        }

        public string CreatePost(string title, string content, string imageUrl, int userStatus)
        {
            var post = _blogFactory.CreatePost();
            post.Title = title;
            post.Content = content;

            var background = _blogFactory.CreateBackground(userStatus);
            var backgroundImage = background.GetBackground();

            // Attempt to add image (only Admin can do this)
            var imageMessage = post.AddImage(imageUrl);

            return $"{post.Publish()} with {backgroundImage}. {imageMessage}";
        }
    }

}
