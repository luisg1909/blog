namespace blog.Interfaces
{
    public interface IBlogFactory
    {
        IPost CreatePost();
        IBackgroundImage CreateBackground(int userStatus);
    }
}
