namespace blog.Interfaces
{
    // IPost.cs
    public interface IPost
    {
        string Title { get; set; }
        string Content { get; set; }
        string AddImage(string imageUrl);
        string Publish();
    }



}
