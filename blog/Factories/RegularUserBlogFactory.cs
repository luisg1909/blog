using blog.Backgrounds;
using blog.Interfaces;
using blog.Models;

namespace blog.Factories
{
    // RegularUserBlogFactory.cs
    public class RegularUserBlogFactory : IBlogFactory
    {
        public IPost CreatePost()
        {
            return new RegularUserPost();
        }

        public IBackgroundImage CreateBackground(int userStatus)
        {
            switch (userStatus)
            {
                case 0: return new StudentBackground();
                case 1: return new MilitaryBackground();
                case 2: return new AnimeBackground();
                default: return new StudentBackground();
            }
        }
    }

}
